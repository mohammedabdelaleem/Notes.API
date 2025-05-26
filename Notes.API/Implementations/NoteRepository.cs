

using Mapster;
using Microsoft.EntityFrameworkCore;
using Notes.API.Reposotories;
using System.Threading.Tasks;

namespace Notes.API.Implementations;

public class NoteRepository : GenericRepository<Note>, INoteRepository
{
	private readonly AppDbContext context;
	public NoteRepository(AppDbContext context) : base(context)
	{
		this.context = context;
	}

	

	public async Task<bool> ToggleArchive(Guid noteId)
	{
		var note = await GetFirstOrDefaultAsync(n=>n.Id == noteId);

		if(note==null || (note.IsVisible && note.IsArchieved)) 
			return false;

		if (note.IsArchieved)
		{
			note.IsArchieved = false;
			note.IsVisible = false;
		}
		else
		{
			note.IsArchieved = true;
			note.IsVisible = true;
		}

		return true;
	}

	public async Task<bool>  ToggleFavourite(Guid noteId)
	{
		var note = await GetFirstOrDefaultAsync(n => n.Id == noteId);

		if (note == null || (note.IsVisible && note.IsArchieved))
			return false;

		note.IsFavourite = !note.IsFavourite;
		return true;
	}

	public void Update(Note note)
	{
		var noteInDB = context.Notes.FirstOrDefault(c => c.Id == note.Id);

		if (noteInDB != null)
		  note.Adapt(noteInDB);

	}

	
}