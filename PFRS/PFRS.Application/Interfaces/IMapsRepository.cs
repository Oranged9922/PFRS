namespace PFRS.Application.Interfaces
{
	using System.Collections.Generic;

	using PFRS.Domain;

	public interface IMapsRepository
	{
		int AddMap(string relpath);
		public MapModel? GetMapById(int id);
		IEnumerable<MapModel> GetMaps();
	}
}
