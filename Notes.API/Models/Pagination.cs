namespace Notes.API.Models;

public class Pagination
{
	public int PageSize { get; set; }
	public int PageNumber { get; set; }
	public object TotalCount { get; internal set; }
}
