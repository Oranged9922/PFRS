namespace PFRS.Infrastructure
{
	using System.Collections.Generic;

	using PFRS.Application.Interfaces;
	using PFRS.Domain;

	public sealed class MapsRepository : IMapsRepository
	{
		List<MapModel> mapModels = new();

		public int AddMap(string relpath)
		{
			if (File.Exists(relpath) is false)
			{
				return -1;
			}

			mapModels.Add(new MapModel()
			{
				Id = mapModels.Count,
				Path = relpath,
				Name = Path.GetFileName(relpath).Split('.')[0]
			});
			return mapModels.Count - 1;
		}

		public MapModel? GetMapById(int id)
		{
			return mapModels.Where(x => x.Id == id).FirstOrDefault();
		}

		public IEnumerable<MapModel> GetMaps()
		{
			return mapModels.AsReadOnly();
		}
	}
}
