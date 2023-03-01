namespace PFRS.Application.Operations.Maps
{
	using PFRS.Application.Interfaces;
	using PFRS.Domain;

	public sealed class GetMapByIdOperation
	{
		private readonly IMapsRepository mapsRepository;

		public GetMapByIdOperation(IMapsRepository mapsRepository)
		{
			this.mapsRepository = mapsRepository;
		}


		public MapModel Execute(int id)
		{
			return mapsRepository.GetMapById(id);
		}
	}
}
