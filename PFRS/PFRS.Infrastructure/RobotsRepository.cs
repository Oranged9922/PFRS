namespace PFRS.Infrastructure
{
	using System.Collections.Generic;
	using System.Drawing;

	using PFRS.Application.Interfaces;
	using PFRS.Domain;

	public sealed class RobotsRepository : IRobotsRepository
	{
		List<RobotModel> robotModels = new();

		public int AddRobot(string dirpath)
		{
			if (Directory.Exists(dirpath) is false)
			{
				return -1;
			}
			try
			{
				var image = new Bitmap(dirpath + "\\image.png");
				robotModels.Add(new RobotModel()
				{
					Id = robotModels.Count,
					Name = dirpath.Split('\\').Last(),
					ImagePath = dirpath + "\\image.png",
					Width = image.Width,
					Height = image.Height,
				});
			}
			catch
			{
				return -1;
			}
			return robotModels.Count - 1;
		}

		public RobotModel? GetRobotById(int id)
		{
			return robotModels.Where(x => x.Id == id).FirstOrDefault();
		}

		public IEnumerable<RobotModel> GetRobots()
		{
			return robotModels.AsReadOnly();
		}
	}
}
