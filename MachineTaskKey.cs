namespace OptimalSchedulingProblem
{
	/// <summary>
	/// Determines machine-task pair
	/// </summary>
	public struct MachineTaskKey
	{
		/// <summary>
		/// Machine id
		/// </summary>
		public readonly int MachineId;

		/// <summary>
		/// Task id
		/// </summary>
		public readonly int TaskId;


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="machineId"></param>
		/// <param name="taskId"></param>
		public MachineTaskKey(int machineId, int taskId)
		{
			MachineId = machineId;
			TaskId = taskId;
		}

		#region Method implementations

		public override int GetHashCode()
		{
			return (MachineId << 16) ^ TaskId;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is MachineTaskKey))
			{
				return false;
			}
			var other = (MachineTaskKey) obj;
			return (other.MachineId == MachineId) && (other.TaskId == TaskId);
		}

		#endregion
	}
}