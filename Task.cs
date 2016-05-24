namespace OptimalSchedulingProblem
{
	/// <summary>
	/// Represents a task
	/// </summary>
	public class Task
	{
		/// <summary>
		/// Identifier
		/// </summary>
		public int Id { get; }

        /// <summary>
        /// Duration
        /// </summary>
        public decimal Duration { get; } 

		/// <summary>
		/// Deadline
		/// </summary>
		public decimal Deadline { get; }

		/// <summary>
		/// Extreme start time
		/// </summary>
		public decimal ExtremeTime
		{
			get
			{
				return Deadline - Duration;
			}
		}

		/// <summary>
		/// Task name
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Description
		/// </summary>
		public string Description { get; }


		/// <summary>
		/// Full constructor
		/// </summary>
		/// <param name="id"></param>
		/// <param name="duration"></param>
		/// <param name="deadline"></param>
		/// <param name="name"></param>
		/// <param name="description"></param>
		public Task(int id, decimal duration, decimal deadline, string name, string description)
		{
			Id = id;
            Duration = duration;
            Deadline = deadline;
			Name = name;
			Description = description;
		}
	}
}