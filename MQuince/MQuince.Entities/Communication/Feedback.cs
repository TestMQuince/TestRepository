﻿using MQuince.Entities.Users;
using MQuince.Enums;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MQuince.Entities
{
    public class Feedback
    {
        private Guid _id;
        public string Comment { get; set; }
        public Guid UserId { get; set; }
        public bool Anonymous { get; set; }
        public bool Publish { get; set; }
        public bool Approved { get; set; }
<<<<<<< HEAD

        public Feedback() { }
=======
>>>>>>> develop
        public Feedback(Guid id, string comment, Guid userId, bool anonymous, bool publish, bool approved)
        {
            Id = id;
            Comment = comment;
            UserId = userId;
            Anonymous = anonymous;
            Publish = publish;
            Approved = approved;
        }

        public Feedback(string comment, Guid userId, bool anonymous, bool publish, bool approved)
            : this(Guid.NewGuid(), comment, userId, anonymous, publish, approved)
        {
        }

        public Guid Id
        {
            get { return _id; }
            set
            {
                _id = value == Guid.Empty ? throw new ArgumentException("Argument can not be Guid.Empty", nameof(Id)) : value;
            }
        }
    }
}
