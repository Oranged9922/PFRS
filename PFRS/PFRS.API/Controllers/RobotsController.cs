namespace PFRS.Api.Controllers
{
	using ErrorOr;

	using PFRS.Application.Facades;
	using PFRS.Domain;

	public sealed class RobotsController : ApiController
	{
		private readonly RobotsFacade facade;

		public RobotsController(RobotsFacade robotsFacade)
		{
			this.facade = robotsFacade;
		}

		/// <summary>
		/// Adds Map to repository. Returns error if error occured or id of added map.
		/// </summary>
		/// <param name="relpath"></param>
		/// <returns></returns>
		public ErrorOr<int> AddRobot(string dirpath)
		{
			return facade.AddRobot(dirpath);
		}

		/// <summary>
		/// Returns map by given id from repository. If Error occured, returns error.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public ErrorOr<RobotModel> GetRobotById(int id)
		{
			return facade.GetRobotById(id);
		}
	}
}
