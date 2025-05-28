using Microsoft.EntityFrameworkCore;
using Notes.API.Data;
using Notes.API.Reposotories;
using System.Linq.Expressions;

namespace Notes.API.Implementations;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
	private readonly AppDbContext context;
	private DbSet<T> dbSet;
	public GenericRepository(AppDbContext context)
	{
		this.context = context;
		dbSet = context.Set<T>();
	}

	public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
	{
		 await  dbSet.AddAsync(entity, cancellationToken);
		return entity;
	}

	public async Task<IEnumerable<T>> GetAllAsync(System.Linq.Expressions.Expression<Func<T, bool>>? predicate = null,
		string? include = null
		, int pageSize = 0, int pageNumber = 1,
		CancellationToken cancellationToken = default)
	{
		IQueryable<T> query = dbSet.AsQueryable();

		if (predicate != null)
		{
			query = query.Where(predicate);
		}

		if(pageSize > 0)
		{
			query = query.Skip(pageSize * (pageNumber-1)).Take(pageSize);
		}

		if (include != null && !string.IsNullOrWhiteSpace(include))
		{
			// context.Categories.Include("Users,Logos,Products").Tolist();
			foreach (var entity in include.Split(",", StringSplitOptions.RemoveEmptyEntries))
			{
				query = query.Include(entity);
			}
		}

		return await query.ToListAsync(cancellationToken);
	}

	public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null, CancellationToken cancellationToken = default)
	{
		var query = dbSet.AsQueryable();

		if (predicate != null)
			query = query.Where(predicate); 

		return await query.CountAsync(cancellationToken);
	}
	public async Task<T> GetFirstOrDefaultAsync(System.Linq.Expressions.Expression<Func<T, bool>>? predicate = null, string? include = null ,CancellationToken cancellationToken = default)
	{
		IQueryable<T> query = dbSet.AsQueryable();

		if (predicate != null)
		{
			query = query.Where(predicate);
		}

		if (include != null && !string.IsNullOrWhiteSpace(include))
		{
			foreach (var entity in include.Split(",", StringSplitOptions.RemoveEmptyEntries))
			{
				query = query.Include(entity);
			}
		}

		return await query.SingleOrDefaultAsync(cancellationToken);
	}

	public void Remove(T entity )
	{
		dbSet.Remove(entity);
	}

	public void RemoveRangeAsync(IEnumerable<T> entities)
	{
		 dbSet.RemoveRange(entities);
	}
}

