using System;
using System.Collections.Generic;
using System.Text;

namespace MQuince.Entities
{
    public class User
    {
        public Guid Id { get; }

        public string Username { get; }

        public User(Guid id, string username)
        {
            Id = id;
            Username = username;
        }

        public User(string username) : this(Guid.NewGuid(), username)
        {
        }
    }
}
