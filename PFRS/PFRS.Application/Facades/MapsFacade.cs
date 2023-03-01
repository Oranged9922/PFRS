namespace PFRS.Application.Facades
{
	using PFRS.Application.Operations.Maps;
	using PFRS.Domain;

	public sealed class MapsFacade
	{
		private readonly GetMapByIdOperation getMapByIdOperation;

		public MapsFacade(GetMapByIdOperation getMapByIdOperation)
		{
			this.getMapByIdOperation = getMapByIdOperation;
		}

		public MapModel GetMapById(int id)
		{
			return getMapByIdOperation.Execute(id);
		}
	}
}
