using System.Collections.Generic;

namespace ApiPractice.Services.Interfaces
{
    public interface ICharacterService
    {
        List<Entities.Character.Character> FindCharacters(int skip, int take, string nameStartsWith);

        Entities.Character.Character FindById(long id);
    }
}
