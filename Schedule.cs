using System.Collections.Generic;

namespace OptimalSchedulingProblem
{
	/// <summary>
	/// Represents a schedule
	/// </summary>
	public class Schedule : List<MachineSchedule>
	{
        /// <summary>
        /// Default constructor
        /// </summary>
        public Schedule() : base()
        {
        }

		/// <summary>
		/// Constructor based on machines
		/// </summary>
		/// <param name="machines"></param>
		public Schedule(IEnumerable<Machine> machines)
		{
			foreach (var machine in machines)
			{
				Add(new MachineSchedule(machine));
			}
		}

		
		public static Schedule BuildSchedule(IEnumerable<Task> tasks, IEnumerable<Machine> machines)
		{

			return new Schedule();
		}
	}
}