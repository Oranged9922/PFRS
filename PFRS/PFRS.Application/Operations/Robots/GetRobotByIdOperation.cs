namespace PFRS.Application.Operations.Robots
{
	using PFRS.Application.Interfaces;
	using PFRS.Domain;

	public sealed class GetRobotByIdOperation
	{
		private readonly IRobotsRepository robotsRepository;

		public GetRobotByIdOperation(IRobotsRepository robotsRepository)
		{
			this.robotsRepository = robotsRepository;
		}

		internal RobotModel? Execute(int id)
		{
			return robotsRepository.GetRobotById(id);
		}
	}
}
