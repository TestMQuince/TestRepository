using MQuince.Entities;
using MQuince.Repository.SQL.PersistenceEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MQuince.Repository.SQL.DataProvider.Util
{
    public class UserMapper
    {
        public static User MapUserPersistenceToUserEntity(UserPersistence user)
            => user == null ? null : new User(user.Id, user.Username);

        public static IEnumerable<User> MapUserPersistenceCollectionToUserEntityCollection(IEnumerable<UserPersistence> users)
            => users.Select(c => MapUserPersistenceToUserEntity(c));
    }
}
