namespace PFRS.Infrastructure
{
	using PFRS.Application.Interfaces;
	using PFRS.Domain;

	public sealed class MapsRepository : IMapsRepository
	{
		public MapsRepository()
		{
		}

		public MapModel GetMapById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
