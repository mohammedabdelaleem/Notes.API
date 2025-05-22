

using Mapster;
using Notes.API.Reposotories;

namespace Notes.API.Implementations;

public class NoteRepository : GenericRepository<Note>, INoteRepository
{
	private readonly AppDbContext context;
	public NoteRepository(AppDbContext context) : base(context)
	{
		this.context = context;
	}

	public void Update(Note note)
	{
		var noteInDB = context.Notes.FirstOrDefault(c => c.Id == note.Id);

		if (noteInDB != null)
		  note.Adapt(noteInDB);

	}
}