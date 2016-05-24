using System.Collections.Generic;

namespace OptimalSchedulingProblem
{
	/// <summary>
	/// Schedule for a single machine
	/// </summary>
	public class MachineSchedule
	{
		/// <summary>
		/// Machine
		/// </summary>
		public Machine Machine { get; private set; }

		/// <summary>
		/// The time of launch
		/// </summary>
		public decimal StartTime { get; set; }

		/// <summary>
		/// Tasks
		/// </summary>
		public LinkedList<Task> Tasks { get; private set; }


		/// <summary>
		/// Full constructor
		/// </summary>
		/// <param name="machine"></param>
		/// <param name="startTime"></param>
		/// <param name="tasks"></param>
		public MachineSchedule(Machine machine, decimal startTime, LinkedList<Task> tasks)
		{
			Machine = machine;
			StartTime = startTime;
			Tasks = tasks;
		}

		/// <summary>
		/// Machine constructor
		/// </summary>
		/// <param name="machine"></param>
		public MachineSchedule(Machine machine)
		: this(machine, decimal.MaxValue, new LinkedList<Task>())
		{
		}

		/// <summary>
		/// Default constructor
		/// </summary>
		public MachineSchedule()
		: this(null, decimal.MaxValue, new LinkedList<Task>())
		{
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="machine"></param>
		/// <returns></returns>
		public virtual MachineSchedule Create(Machine machine)
		{
			return new MachineSchedule(machine);
		}
	}
}