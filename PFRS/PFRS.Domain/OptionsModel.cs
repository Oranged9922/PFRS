namespace PFRS.Domain
{
	public sealed class OptionsModel
	{
		public required List<EntityReference> MapOptions { get; set; }
		public int SelectedMapOption { get; set; }

		public required List<EntityReference> RobotOptions { get; set; }
		public int SelectedRobotOption { get; set; }
	}
}
