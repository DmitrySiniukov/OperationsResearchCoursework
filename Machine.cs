namespace OptimalSchedulingProblem
{
	/// <summary>
	/// Represents a machine
	/// </summary>
	public class Machine
	{
		/// <summary>
		/// Identifier
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Name
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
		/// <param name="name"></param>
		/// <param name="description"></param>
		public Machine(int id, string name, string description)
		{
			Id = id;
			Name = name;
			Description = description;
		}
	}
}