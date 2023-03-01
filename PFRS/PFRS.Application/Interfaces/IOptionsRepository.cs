namespace PFRS.Application.Interfaces
{
	using PFRS.Domain;

	public interface IOptionsRepository
	{
		public OptionsModel GetOptions();
	}
}
