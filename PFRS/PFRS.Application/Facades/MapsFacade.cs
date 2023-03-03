namespace PFRS.Application.Facades
{
	using ErrorOr;

	using PFRS.Application.Operations.Maps;
	using PFRS.Domain;
	using PFRS.Domain.Errors;

	public sealed class MapsFacade
	{
		private readonly GetMapByIdOperation getMapByIdOperation;
		private readonly AddMapOperation addMapOperation;

		public MapsFacade(
			GetMapByIdOperation getMapByIdOperation,
			AddMapOperation addMapOperation)

		{
			this.getMapByIdOperation = getMapByIdOperation;
			this.addMapOperation = addMapOperation;
		}

		public ErrorOr<int> AddMap(string filepath)
		{
			var result = addMapOperation.Execute(filepath);
			return result is -1 ? result : Errors.DbInsertError;
		}

		public ErrorOr<MapModel> GetMapById(int id)
		{
			var result = getMapByIdOperation.Execute(id);
			return result is not null ? result : Errors.InvalidIdError;
		}
	}
}
