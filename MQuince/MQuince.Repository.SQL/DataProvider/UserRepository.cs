using MQuince.Entities;
using MQuince.Repository.Contracts;
using MQuince.Repository.SQL.DataAccess;
using MQuince.Repository.SQL.DataProvider.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MQuince.Repository.SQL.DataProvider
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> GetAll()
        {
            using (MQuinceDbContext _context = new MQuinceDbContext())
            {
                //u _contextu se nalaze svi korisnici u bazi
                return UserMapper.MapUserPersistenceCollectionToUserEntityCollection(_context.Users.ToList());
            }
        }

        public User GetById(Guid id)
        {
            using (MQuinceDbContext _context = new MQuinceDbContext())
            {
                //pomocu lambda izraza se izvuce korisnik sa Id-jem koji je isti kao prosledjeni
                //isti rezultat ima i foreach gde se unutar nekog if-a porede id-jevi
                return UserMapper.MapUserPersistenceToUserEntity(_context.Users.SingleOrDefault(c => c.Id.Equals(id)));
            }
        }
    }
}
