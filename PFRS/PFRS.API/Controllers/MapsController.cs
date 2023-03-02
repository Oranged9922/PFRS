namespace PFRS.Api.Controllers
{
	using ErrorOr;

	using PFRS.Application.Facades;
	using PFRS.Domain;

	public sealed class MapsController : ApiController
	{
		private readonly MapsFacade facade;

		public MapsController(MapsFacade facade)
		{
			this.facade = facade;
		}

		/// <summary>
		/// Adds Map to repository. Returns error if error occured or id of added map.
		/// </summary>
		/// <param name="relpath"></param>
		/// <returns></returns>
		public ErrorOr<int> AddMap(string relpath)
		{
			return facade.AddMap(relpath);
		}

		/// <summary>
		/// Returns map by given id from repository. If Error occured, returns error.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public ErrorOr<MapModel> GetMapById(int id)
		{
			return facade.GetMapById(id);
		}
	}
}
