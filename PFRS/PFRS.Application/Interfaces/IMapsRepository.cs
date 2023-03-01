namespace PFRS.Application.Interfaces
{
	using PFRS.Domain;

	public interface IMapsRepository
	{
		public MapModel GetMapById(int id);
	}
}
