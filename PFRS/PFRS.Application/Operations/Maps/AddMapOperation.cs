namespace PFRS.Application.Operations.Maps
{
	using PFRS.Application.Interfaces;

	public sealed class AddMapOperation
	{
		private readonly IMapsRepository mapsRepository;
		public AddMapOperation(IMapsRepository mapsRepository)
		{
			this.mapsRepository = mapsRepository;
		}

		public int Execute(string relpath)
		{
			return mapsRepository.AddMap(relpath);
		}
	}
}
