using System.ComponentModel.DataAnnotations;

namespace Notes.API.Contracts;

public class NoteUpdateDto
{
	public Guid Id { get; set; }

	[StringLength(100, MinimumLength = 2, ErrorMessage = "Title must be between 2 and 100 characters.")]
	public string Title { get; set; }

	[MaxLength(200, ErrorMessage = "Max Length Is 200 !!")]
	public string Description { get; set; }

	public bool IsVisible { get; set; }
	public bool IsArchieved { get; set; } = false;
	public bool IsFavourite { get; set; } = false;
}
