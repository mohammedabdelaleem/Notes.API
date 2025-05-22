using Mapster;
using Microsoft.AspNetCore.Mvc;
using Notes.API.Contracts;
using Notes.API.Reposotories;

namespace Notes.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class NoteController : ControllerBase
{
	private readonly IUnitOfWork _unitOfWork;

	public NoteController(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;

	}

	[HttpGet("all")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<ActionResult<Note>> GetAll(CancellationToken cancellationToken=default)
	{
		var notes = await _unitOfWork.Note.GetAllAsync(cancellationToken: cancellationToken);

		if(notes != null && notes.Count() >= 1)
		{
			return Ok(notes.Adapt<IEnumerable<NoteDto>>());
		}
		return BadRequest(new {message = "No Notes Found"});
	}


	[HttpGet("{id:guid}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public async Task<ActionResult<Note>> GetAll([FromBody] Guid id,CancellationToken cancellationToken = default)
	{
		var note = await _unitOfWork.Note.GetFirstOrDefaultAsync(n=>n.Id == id,cancellationToken: cancellationToken);

		if (note != null)
		{
			return Ok(note.Adapt<NoteDto>());
		}
		return NotFound(new { message = "No Notes Found" });
	}



}
