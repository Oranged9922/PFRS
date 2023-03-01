namespace PFRS.Api.Controllers
{
	using ErrorOr;

	using PFRS.Application.Facades;
	using PFRS.Domain;

	public sealed class OptionsController : ApiController
	{
		private readonly OptionsFacade facade;

		public OptionsController(OptionsFacade facade)
		{
			this.facade = facade;
		}
		public ErrorOr<OptionsModel> GetOptions()
		{
			return facade.GetOptions();
		}

		public ErrorOr<bool> SetOptions(OptionsModel options)
		{
			throw new NotImplementedException();
		}
	}
}
