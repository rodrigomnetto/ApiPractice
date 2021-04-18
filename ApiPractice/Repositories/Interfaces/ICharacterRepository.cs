using System.Collections.Generic;

namespace ApiPractice.Repositories.Interfaces
{
    public interface ICharacterRepository
    {
        List<Entities.Character.Character> FindCharacters(int skip, int take, string nameStartsWith);

        Entities.Character.Character FindById(long id);
    }
}
