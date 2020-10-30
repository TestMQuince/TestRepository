using MQuince.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MQuince.Entities
{
    public class Feedback
    {
        private Guid _id;
        public Grade Grade { get; }

        public string Comment { get; }

        public Guid GradedUserId { get; }

        //Koristi se kada se feedback dobavlja iz baze, iz tog razloga mu prosledjujemo id
        public Feedback(Guid id, string comment, Grade grade, Guid userId)
        {
            Id = id;
            Comment = comment;
            Grade = grade;
            GradedUserId = userId;
        }

        //Koristi se kada se pravi novi feedback, pozivamo prethodno napravljeni konstruktor sa novim id-jem
        public Feedback(string comment, Grade grade, Guid userId)
            : this(Guid.NewGuid(), comment, grade, userId)
        {
        }

        //Ovo je samo primer kako se kroz setter moze proveriti da li je poslata 
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
