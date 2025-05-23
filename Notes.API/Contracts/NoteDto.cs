using System.ComponentModel.DataAnnotations;

namespace Notes.API.Contracts;

public class NoteDto
{
	public Guid Id { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public bool IsVisible { get; set; }

}
