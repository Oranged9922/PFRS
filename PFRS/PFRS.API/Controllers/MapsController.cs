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


		public ErrorOr<MapModel> GetMapById(int id)
		{
			return facade.GetMapById(id);
		}
	}
}
