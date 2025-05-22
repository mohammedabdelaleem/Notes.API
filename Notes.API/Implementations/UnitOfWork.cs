using Notes.API.Reposotories;

namespace Notes.API.Implementations;

public class UnitOfWork : IUnitOfWork
{
	private readonly AppDbContext context;
	public INoteRepository Note { get; private set; }


	public UnitOfWork(AppDbContext context)
	{
		this.context = context;
		Note = new NoteRepository(context);
	}
	public async Task<int> Complete(CancellationToken cancellationToken=default)
	{
		return await context.SaveChangesAsync(cancellationToken);
	}

	public void Dispose()
	{
		 context.DisposeAsync();
	}

	
}