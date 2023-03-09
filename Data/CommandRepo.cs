using Microsoft.EntityFrameworkCore;
using MinimalAPI.Models;

namespace MinimalAPI.Data
{
  public class CommandRepo : ICommandRepo
  {
    private readonly AppDbContext _context;

    public CommandRepo(AppDbContext context)
    {
      _context = context;
    }

    public async Task CreateCommand(Command cmd)
    {
      if (cmd == null)
      {
        throw new ArgumentNullException(nameof(cmd));
      }

      await _context.AddAsync(cmd);
    }

    public void DeleteCommand(Command cmd)
    {
      if (cmd == null)
      {
        throw new ArgumentNullException(nameof(cmd));
      }

      _context.Remove(cmd);
    }

    public async Task<IEnumerable<Command>?> GetAllCommands()
    {
      return await _context.Commands.ToListAsync();
    }

    public async Task<Command?> GetCommandById(int id)
    {
      return await _context.Commands.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task SaveChangesAsync()
    {
      await _context.SaveChangesAsync();
    }
  }
}