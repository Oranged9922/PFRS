namespace PFRS.Domain.Errors
{
	using ErrorOr;

	public static class Errors
	{
		public enum ErrorType
		{
			RepositoryError = 1,
		};

		public static Error InvalidIdError { get; set; }
			= Error.Custom((int)ErrorType.RepositoryError,
				"RepositoryErrors.InvalidId",
				   "Entity with given Id does not exist. If error persists, " +
				"check if you are requesting existing Id that is in your database.");
		public static ErrorOr<int> DbInsertError { get; set; }
	}
}

