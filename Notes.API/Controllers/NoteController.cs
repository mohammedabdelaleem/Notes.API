using Mapster;
using Microsoft.AspNetCore.Mvc;
using Notes.API.Contracts;
using Notes.API.Models;
using Notes.API.Reposotories;
using System.Net;
using System.Text.Json;

namespace Notes.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class NoteController : ControllerBase
{
	private ApiResponse _response;
	private readonly IUnitOfWork _unitOfWork;

	public NoteController(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;

	}

	[HttpGet("all")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status500InternalServerError)]
	public async Task<ActionResult<ApiResponse>> GetAll(int pageSize = 0, int pageNumber = 1, CancellationToken cancellationToken = default)
	{
		try
		{
			var notes = await _unitOfWork.Note.GetAllAsync(pageSize: pageSize, pageNumber: pageNumber, cancellationToken: cancellationToken);

			if (notes == null || !notes.Any())
			{
				_response = new(statusCode: HttpStatusCode.NotFound, isSuccess: false,
					errorMessages: new List<string>() { "Notes Not Found " });

				return _response;
			}

			var pagination = new Pagination()
			{
				PageNumber = pageNumber,
				PageSize = pageSize
			};

			Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagination));

			_response = new ApiResponse(statusCode: HttpStatusCode.OK, isSuccess: true,
				result: notes.Adapt<IEnumerable<NoteDto>>());

			return Ok(_response);

		}
		catch (Exception ex)
		{
			_response = new(statusCode: HttpStatusCode.InternalServerError, isSuccess: false, errorMessages: new List<string> { ex.Message });
			return _response;
		}
	}


	[HttpGet("{id:guid}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public async Task<ActionResult<ApiResponse>> Get(Guid id, CancellationToken cancellationToken = default)
	{
		try
		{
			var note = await _unitOfWork.Note.GetFirstOrDefaultAsync(n => n.Id == id, cancellationToken: cancellationToken);

			if (note == null)
				return NotFound(new { message = "No Note Found" });


			_response = new ApiResponse(statusCode: HttpStatusCode.OK, isSuccess: true,
					result: note.Adapt<NoteDto>());
			return Ok(_response);

		}
		catch (Exception ex)
		{
			_response = new(statusCode: HttpStatusCode.InternalServerError, isSuccess: false, errorMessages: new List<string> { ex.Message });
			return _response;
		}
	}

	[HttpPost]
	[ProducesResponseType(StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status500InternalServerError)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<ActionResult<ApiResponse>> Create([FromBody] NoteCreateDto dto, CancellationToken cancellationToken = default)
	{
		try
		{
			if (!ModelState.IsValid)
				return BadRequest(new { message = "Recheck The Note Model Please !!!" });


			var createdNote = await _unitOfWork.Note.AddAsync(dto.Adapt<Note>(), cancellationToken: cancellationToken);


			if (createdNote == null)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, new { message = "Failed to create note." });
			}

			if (await _unitOfWork.CompleteAsync(cancellationToken) <= 0)
				return StatusCode(StatusCodes.Status500InternalServerError, new { message = "Creation failed. Please try again later." });

			_response = new ApiResponse(statusCode: HttpStatusCode.Created, isSuccess: true,
				result: createdNote.Adapt<NoteUpdateDto>());

			return CreatedAtAction(nameof(Get), new { id = createdNote.Id }, _response);

		}
		catch (Exception ex)
		{
			_response = new(statusCode: HttpStatusCode.InternalServerError, isSuccess: false, errorMessages: new List<string> { ex.Message });
			return _response;
		}
	}

	[HttpDelete("{id:guid}")]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status500InternalServerError)]
	public async Task<ActionResult<ApiResponse>> Delete(Guid id, CancellationToken cancellationToken = default)
	{
		try
		{
			var entity = await _unitOfWork.Note.GetFirstOrDefaultAsync(n => n.Id == id, cancellationToken: cancellationToken);

			if (entity == null)
				return NotFound(new { message = "No Note Found" });

			_unitOfWork.Note.Remove(entity);

			if(await _unitOfWork.CompleteAsync(cancellationToken) <= 0)
				return StatusCode(StatusCodes.Status500InternalServerError, new { message = "Update failed. Please try again later." });

			_response = new(statusCode: HttpStatusCode.NoContent, isSuccess: true);
			return Ok(_response);
		}
		catch (Exception ex)
		{
			_response = new(statusCode: HttpStatusCode.InternalServerError, isSuccess: false, errorMessages: new List<string> { ex.Message });
			return _response;
		}

	}



	[HttpPut("{id:guid}")]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status500InternalServerError)]
	public async Task<ActionResult<ApiResponse>> Update(Guid id, [FromBody] NoteUpdateDto dto, CancellationToken cancellationToken = default)
	{
		try
		{
			if(!ModelState.IsValid)
				return BadRequest(new { message = "Recheck The Note Model Please !!!" });

			if(id != dto.Id)
				return BadRequest(new { message = "Id Not Equal Model's Id ????" });

			_unitOfWork.Note.Update(dto.Adapt<Note>());
			await _unitOfWork.CompleteAsync(cancellationToken);

			//_response = new(HttpStatusCode.OK, isSuccess: true);
			//return Ok(_response);

			return NoContent();
		}
		catch (Exception ex)
		{
			_response = new(statusCode: HttpStatusCode.InternalServerError, isSuccess: false, errorMessages: new List<string> { ex.Message });
			return _response;
		}

	}

}


