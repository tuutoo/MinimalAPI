using MinimalAPI.Models;

namespace MinimalAPI.Data
{
  public interface ICommandRepo
  {
    Task SaveChanges();

    Task<Command?> GetCommandById(int id);

    Task<IEnumerable<Command>?> GetAllCommand();

    Task CreateCommand(Command cmd);

    void DeleteCommand(Command cmd);
  }
}