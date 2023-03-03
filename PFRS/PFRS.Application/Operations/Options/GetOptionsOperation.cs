namespace PFRS.Application.Operations.Options
{
	using PFRS.Application.Interfaces;
	using PFRS.Domain;

	public sealed class GetOptionsOperation
	{
		private readonly IMapsRepository mapsRepository;
		private readonly IRobotsRepository robotsRepository;

		public GetOptionsOperation(IMapsRepository mapsRepository, IRobotsRepository robotsRepository)
		{
			this.mapsRepository = mapsRepository;
			this.robotsRepository = robotsRepository;
		}

		public OptionsModel Execute()
		{
			var options = new OptionsModel()
			{
				MapOptions =
					mapsRepository.GetMaps()
						.Select(x =>
							new EntityReference() { Id = x.Id, Name = x.Name })
						.ToList(),
				SelectedMapOption = -1,

				RobotOptions =
					robotsRepository.GetRobots()
						.Select(x =>
							new EntityReference() { Id = x.Id, Name = x.Name })
						.ToList(),
				SelectedRobotOption = -1,
			};

			return options;
		}
	}
}
