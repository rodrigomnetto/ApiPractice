using ApiPractice.Repositories.Interfaces;
using ApiPractice.Services.Interfaces;
using System.Collections.Generic;

namespace ApiPractice.Services.Character
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;

        public CharacterService(ICharacterRepository characterRepository)
            => _characterRepository = characterRepository;

        public Entities.Character.Character FindById(long id)
            => _characterRepository.FindById(id);

        public List<Entities.Character.Character> FindCharacters(int skip, int take, string nameStartsWith)
            => _characterRepository.FindCharacters(skip, take, nameStartsWith);
    }
}
