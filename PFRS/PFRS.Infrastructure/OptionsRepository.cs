namespace PFRS.Infrastructure
{
	using PFRS.Application.Interfaces;
	using PFRS.Domain;

	public sealed class OptionsRepository : IOptionsRepository
	{
		public static OptionsModel options = new()
		{

		};
		public OptionsRepository()
		{
		}

		public OptionsModel GetOptions()
		{
			return options;
		}
	}
}
