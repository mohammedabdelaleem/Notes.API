using System.Net;

namespace Notes.API.Models;

public class ApiResponse
{
	public HttpStatusCode StatusCode { get; set; }
	public IEnumerable<string>ErrorMessages { get; set; }
	public bool IsSuccess { get; set; }
	public object Result { get; set; }

	public ApiResponse()
	{
		StatusCode = default;
		IsSuccess = default;
		ErrorMessages = [];
		Result = new();
	}
	public ApiResponse(HttpStatusCode statusCode,
		object result = null, bool isSuccess = true, List<string> errorMessages = null)
	{
		StatusCode = statusCode;
		IsSuccess = isSuccess;
		ErrorMessages = errorMessages;
		Result = result ?? new();
	}

}

