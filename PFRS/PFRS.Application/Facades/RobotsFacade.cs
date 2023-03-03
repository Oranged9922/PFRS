namespace PFRS.Application.Facades
{
	using ErrorOr;

	using PFRS.Application.Operations.Robots;
	using PFRS.Domain;
	using PFRS.Domain.Errors;

	public class RobotsFacade
	{
		private readonly AddRobotOperation addRobotOperation;
		private readonly GetRobotByIdOperation getRobotByIdOperation;

		public RobotsFacade(AddRobotOperation addRobotOperation, GetRobotByIdOperation getRobotByIdOperation)
		{
			this.addRobotOperation = addRobotOperation;
			this.getRobotByIdOperation = getRobotByIdOperation;
		}

		public ErrorOr<int> AddRobot(string dirpath)
		{
			var result = addRobotOperation.Execute(dirpath);
			return result is -1 ? result : Errors.DbInsertError;
		}

		public ErrorOr<RobotModel> GetRobotById(int id)
		{
			var result = getRobotByIdOperation.Execute(id);
			return result is not null ? result : Errors.InvalidIdError;
		}
	}
}
