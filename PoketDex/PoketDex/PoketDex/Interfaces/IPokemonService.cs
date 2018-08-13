namespace PoketDex.Interfaces
{
    using PoketDex.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPokemonService
    {
        Task<IEnumerable<Pokemon>> GetAllPokemonsAsync();
    }
}
