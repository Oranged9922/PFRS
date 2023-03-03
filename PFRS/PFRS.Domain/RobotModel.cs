namespace PFRS.Domain
{

	public sealed class RobotModel
	{
		public required int Id { get; set; }
		public required string Name { get; set; }
		public required string ImagePath { get; set; }
		public required int Height { get; set; }
		public required int Width { get; set; }
	}
}
