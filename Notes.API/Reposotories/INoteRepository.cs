using Notes.API.Models.Entities;

namespace Notes.API.Reposotories;

public interface INoteRepository : IGenericRepository<Note>
{
	void Update(Note category);
}
