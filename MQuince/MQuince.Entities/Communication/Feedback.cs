using MQuince.Entities.Users;
using MQuince.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MQuince.Entities
{
    public class Feedback
    {
        private Guid _id;
        public Grade Grade { get; set; }
        public string Comment { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public bool Anonymous { get; set; }

        public Feedback(Guid id, Grade grade, string comment, Guid userId, DateTime date, bool anonymous)
        {
            Id = id;
            Comment = comment;
            Grade = grade;
            UserId = userId;
            Date = date;
            Anonymous = anonymous;
        }

        public Feedback(Grade grade, string comment, Guid userId, DateTime date, bool anonymous)
            : this(Guid.NewGuid(), grade, comment, userId, date, anonymous)
        {
        }

        public Guid Id
        {
            get { return _id; }
            private set
            {
                _id = value == Guid.Empty ? throw new ArgumentException("Argument can not be Guid.Empty", nameof(Id)) : value;
            }
        }
    }
}
