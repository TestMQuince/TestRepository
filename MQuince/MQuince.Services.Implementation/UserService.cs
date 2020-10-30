using MQuince.Entities;
using MQuince.Repository.Contracts;
using MQuince.Services.Contracts.DTO;
using MQuince.Services.Contracts.IdentifiableDTO;
using MQuince.Services.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MQuince.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepositoty)
        {
            _userRepository = userRepositoty;
        }

        public IEnumerable<IdentifiableDTO<UserDTO>> GetAll()
            => _userRepository.GetAll().Select(c => CreateUserDTO(c)); //pozivamo metodu za mapiranje za svaki objekat iz baze


        public IdentifiableDTO<UserDTO> GetById(Guid id)
            => CreateUserDTO(_userRepository.GetById(id));


        //metoda za mapiranje Entiteta na DTO
        private IdentifiableDTO<UserDTO> CreateUserDTO(User user)
        {
            if (user == null) return null;

            return new IdentifiableDTO<UserDTO>() { Id = user.Id, EntityDTO = new UserDTO() { Username = user.Username } };
        }
    }
}
