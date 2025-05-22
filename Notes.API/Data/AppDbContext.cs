using Microsoft.EntityFrameworkCore;
using Notes.API.Models.Entities;
using System.Diagnostics.Metrics;
using System.Text.Json;

namespace Notes.API.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions options) : base(options){}

	public DbSet<Note> Notes { get; set; }


	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		string notesJson = System.IO.File.ReadAllText("notes.json");
		List<Note> notes = JsonSerializer.Deserialize<List<Note>>(notesJson)!;
		foreach (Note country in notes)
		{
			modelBuilder.Entity<Note>().HasData(country);
		}
	}
}
