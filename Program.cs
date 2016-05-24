using System;
using System.Collections.Generic;
using System.IO;

namespace OptimalSchedulingProblem
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			const string message = "Format of data in the file is incorrect";
			var separators = new[] { ' ', '\t', ';' };

			var tasks = new List<Task>();
			var machines = new List<Machine>();

			var question = false;
			while (true)
			{
				if (question)
				{
					string answer;
					do
					{
						Console.Write("Continue? (\"yes\"/\"no\") ");
						answer = Console.ReadLine();
					} while (answer != "yes" && answer != "no");

					if (answer == "no")
					{
						Console.ReadKey();
						return;
					}
				}
				question = true;

				Console.Write("Input file name: ");
				var fileName = Console.ReadLine();
				while (!File.Exists(fileName))
				{
					Console.WriteLine("File does not exist.");
					Console.Write("Input file name: ");
					fileName = Console.ReadLine();
				}

				// ReSharper disable once AssignNullToNotNullAttribute
				var lines = File.ReadAllLines(fileName);

				if (lines.Length == 0)
				{
					Console.WriteLine(message);
					continue;
				}

				int tasksNumber;
				if (!int.TryParse(lines[0], out tasksNumber) || tasksNumber < 0)
				{
					Console.WriteLine(message);
					continue;
				}

				if (lines.Length < tasksNumber + 2)
				{
					Console.WriteLine(message);
					continue;
				}

				var success = true;
				tasks.Clear();
				for (var i = 0; i < tasksNumber; ++i)
				{
					var parts = lines[i + 1].Split(separators, StringSplitOptions.RemoveEmptyEntries);
					if (parts.Length < 3)
					{
						success = false;
						break;
					}

					int id;
					decimal duration;
					decimal deadline;
					if (!int.TryParse(parts[0], out id) || !decimal.TryParse(parts[1].Replace(',', '.'), out duration) ||
					!decimal.TryParse(parts[2].Replace(',', '.'), out deadline))
					{
						success = false;
						break;
					}

					tasks.Add(new Task(id, duration, deadline, string.Empty, string.Empty));
				}
				if (!success)
				{
					Console.WriteLine(message);
					continue;
				}

				int machinesNumber;
				if (!int.TryParse(lines[tasksNumber + 1], out machinesNumber) || machinesNumber < 0)
				{
					Console.WriteLine(message);
					continue;
				}

				if (lines.Length < tasksNumber + machinesNumber + 2)
				{
					Console.WriteLine(message);
					continue;
				}

				machines.Clear();
				for (var i = 0; i < machinesNumber; ++i)
				{
					var parts = lines[i + tasksNumber + 2].Split(separators, StringSplitOptions.RemoveEmptyEntries);
					if (parts.Length == 0)
					{
						success = false;
						break;
					}

					int id;
					if (!int.TryParse(parts[0], out id))
					{
						success = false;
						break;
					}

					machines.Add(new Machine(id, string.Empty, string.Empty));
				}

				if (!success)
				{
					Console.WriteLine(message);
					continue;
				}

				var schedule = Schedule<MachineSchedule>.BuildSchedule(tasks, machines);

				foreach (var machineSchedule in schedule)
				{
					Console.WriteLine("Machine #{0}", machineSchedule.Machine.Id);
					var startTime = machineSchedule.StartTime;
					foreach (var task in machineSchedule.Tasks)
					{
						Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}", task.Id, task.Duration, task.Deadline, startTime, startTime + task.Duration);
						startTime += task.Duration;
					}
				}
			}
		}
	}
}