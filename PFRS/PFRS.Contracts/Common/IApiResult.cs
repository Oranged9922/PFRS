namespace PFRS.Contracts.Common
{
	public interface IApiResult
	{
		bool IsSuccess { get; }
		bool IsError { get; }
	}
}
