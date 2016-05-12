using System;

namespace OptimalSchedulingProblem
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var tasks = new Task[] {
				new Task(1, 2, 6, "Task1", ""),
				new Task(2, 1, 7, "Task2", ""),
				new Task(3, 9, 18, "Task3", ""),
				new Task(4, 6, 18, "Task4", ""),
				new Task(5, 3, 16, "Task5", ""),
				new Task(6, 4, 20, "Task6", ""),
				new Task(7, 1, 17, "Task7", ""),
				new Task(8, 1, 18, "Task8", ""),
				new Task(9, 1, 19, "Task9", ""),
				new Task(10, 2, 22, "Task10", ""),
				new Task(11, 17, 37, "Task11", ""),
				new Task(12, 9, 34, "Task12", ""),
				new Task(13, 39, 65, "Task13", ""),
				new Task(14, 20, 50, "Task14", ""),
				new Task(15, 16, 52, "Task15", ""),
				new Task(16, 4, 54, "Task16", "")
			};

			var machines = new Machine[] {
				new Machine(1, "Machine1", ""),
				new Machine(2, "Machine2", ""),
				new Machine(3, "Machine3", "")
			};

			Schedule.BuildSchedule(tasks, machines);

			Console.ReadKey();
		}
	}
}