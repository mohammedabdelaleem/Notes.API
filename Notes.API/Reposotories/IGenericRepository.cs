namespace Notes.API.Reposotories;

using System.Collections.Generic;
using System.Linq.Expressions;


	public interface IGenericRepository<T> where T : class
	{

	// context.Notes.ToList();
	// context.Notes.Include("Products").ToList();
	// context.Notes.Where(c=>c.Id==id).ToList();
		Task<IEnumerable<T> > GetAllAsync(Expression<Func<T, bool>>? predicate = null, string? include = null, CancellationToken cancellationToken = default);


	// context.Notes.ToSingleOrDefault();
	// context.Notes.Include("Products").ToSingleOrDefault();
	// context.Notes.Where(c=>c.Id==id).ToSingleOrDefault();
	Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>>? predicate = null, string? include = null, CancellationToken cancellationToken = default);

		Task AddAsync(T entity, CancellationToken cancellationToken = default);

		void Remove(T entity);
		void RemoveRangeAsync(IEnumerable<T> entities);

	}


