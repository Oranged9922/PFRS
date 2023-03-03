namespace PFRS.Application.Operations.Robots
{
	using PFRS.Application.Interfaces;

	public sealed class AddRobotOperation
	{
		private readonly IRobotsRepository robotsRepository;

		public AddRobotOperation(IRobotsRepository robotsRepository)
		{
			this.robotsRepository = robotsRepository;
		}

		internal int Execute(string dirpath)
		{
			return robotsRepository.AddRobot(dirpath);
		}
	}
}
