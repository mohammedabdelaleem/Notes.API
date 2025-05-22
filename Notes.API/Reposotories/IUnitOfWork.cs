namespace Notes.API.Reposotories;

public interface IUnitOfWork : IDisposable
{
	INoteRepository Note { get; }  // at controller 

	Task<int> Complete(CancellationToken cancellationToken = default); // save changes
}