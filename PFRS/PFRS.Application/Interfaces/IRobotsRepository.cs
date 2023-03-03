namespace PFRS.Application.Interfaces
{
	using System.Collections.Generic;

	using PFRS.Domain;

	public interface IRobotsRepository
	{
		int AddRobot(string filepath);
		RobotModel? GetRobotById(int id);
		IEnumerable<RobotModel> GetRobots();
	}
}
