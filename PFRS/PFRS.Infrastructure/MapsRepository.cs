namespace PFRS.Infrastructure
{
	using System.Collections.Generic;
	using System.Drawing;

	using PFRS.Application.Interfaces;
	using PFRS.Domain;

	public sealed class MapsRepository : IMapsRepository
	{
		List<MapModel> mapModels = new();

		public int AddMap(string filepath)
		{
			if (File.Exists(filepath) is false)
			{
				return -1;
			}
			try
			{
				var image = new Bitmap(filepath);
				mapModels.Add(new MapModel()
				{
					Id = mapModels.Count,
					Width = image.Width,
					Height = image.Height,
					Path = filepath,
					Name = Path.GetFileName(filepath).Split('.')[0]
				});

			}

			catch
			{
				return -1;
			}
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
