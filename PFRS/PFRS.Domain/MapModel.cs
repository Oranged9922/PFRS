namespace PFRS.Domain
{

	public sealed class MapModel
	{
		public required int Id { get; set; }
		public required string Path { get; set; }

		public required int Width { get; set; }
		public required int Height { get; set; }
		public required string Name { get; set; }
	}
}
