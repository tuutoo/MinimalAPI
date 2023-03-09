using MinimalAPI.Models;

namespace MinimalAPI.Data
{
    public interface ICommandRepo
    {
        Task SaveChangesAsync();

        Task<Command?> GetCommandById(int id);

        Task<IEnumerable<Command>?> GetAllCommands();

        Task CreateCommand(Command cmd);

        void DeleteCommand(Command cmd);
    }
}