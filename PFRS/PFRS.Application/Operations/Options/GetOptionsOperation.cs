namespace PFRS.Application.Operations.Options
{
	using PFRS.Application.Interfaces;
	using PFRS.Domain;

	public sealed class GetOptionsOperation
	{
		private readonly IMapsRepository mapsRepository;

		public GetOptionsOperation(IMapsRepository mapsRepository)
		{
			this.mapsRepository = mapsRepository;
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
			};

			return options;
		}
	}
}
