namespace Notes.API.Reposotories;

using System.Collections.Generic;
using System.Linq.Expressions;


	public interface IGenericRepository<T> where T : class
	{

	// context.Notes.ToList();
	// context.Notes.Include("Products").ToList();
	// context.Notes.Where(c=>c.Id==id).ToList();
		Task<IEnumerable<T> > GetAllAsync(Expression<Func<T, bool>>? predicate = null, string? include = null,
			int pageSize = 0, int pageNumber = 1, CancellationToken cancellationToken = default);


	// context.Notes.ToSingleOrDefault();
	// context.Notes.Include("Products").ToSingleOrDefault();
	// context.Notes.Where(c=>c.Id==id).ToSingleOrDefault();
	Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>>? predicate = null, string? include = null, CancellationToken cancellationToken = default);

	Task<int> Count(CancellationToken cancellationToken = default);


	Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);

		void Remove(T entity);
		void RemoveRangeAsync(IEnumerable<T> entities);

	}


