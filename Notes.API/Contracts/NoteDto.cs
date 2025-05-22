using System.ComponentModel.DataAnnotations;

namespace Notes.API.Contracts;

public class NoteDto
{
	public string Title { get; set; }
	public string Description { get; set; }

}
