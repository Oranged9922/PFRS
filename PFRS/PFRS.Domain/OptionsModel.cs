namespace PFRS.Domain
{
	public sealed class OptionsModel
	{
		public required List<EntityReference> MapOptions { get; set; }
		public int SelectedMapOption { get; set; }
	}
}
