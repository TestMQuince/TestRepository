﻿using MQuince.Entities;
using MQuince.Repository.Contracts;
using MQuince.Repository.SQL.DataAccess;
using MQuince.Repository.SQL.DataProvider.Util;
using MQuince.Repository.SQL.PersistenceEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MQuince.Repository.SQL.DataProvider
{
    public class FeedbackRepository : IFeedbackRepository
    {
        public void Create(Feedback entity)
        {
            using (MQuinceDbContext _context = new MQuinceDbContext())
            {
                _context.Feedbacks.Add(FeedbackMapper.MapFeedbackEntityToFeedbackPersistence(entity));
                _context.SaveChanges(); //ako ne sacuvamo nece se update-ovati baza
            }
        }

        public bool Delete(Guid id)
        {
            using (MQuinceDbContext _context = new MQuinceDbContext())
            {
                FeedbackPersistence feedback = _context.Feedbacks.Find(id);
                if (feedback == null) return false; //u principu vracamo true ili false, kao indikator uspesnosti operacije, ako ne pronadjemo id, operacija nije uspesna

                _context.Feedbacks.Remove(feedback);
                _context.SaveChanges(); // cuvamo promene
                return true;
            }
        }

        public IEnumerable<Feedback> GetAll()
        {
            using (MQuinceDbContext _context = new MQuinceDbContext())
            {
                return FeedbackMapper.MapFeedbackPersistenceCollectionToFeedbackEntityCollection(_context.Feedbacks.ToList());
            }
        }

        public Feedback GetById(Guid id)
        {
            using (MQuinceDbContext _context = new MQuinceDbContext())
            {
                //pomocu lambda izraza se izvuce korisnik sa Id-jem koji je isti kao prosledjeni
                //isti rezultat ima i foreach gde se unutar nekog if-a porede id-jevi
                return FeedbackMapper.MapFeedbackPersistenceToFeedbackEntity(_context.Feedbacks.SingleOrDefault(c => c.Id.Equals(id)));
            }
        }

        public void Update(Feedback entity)
        {
            using (MQuinceDbContext _context = new MQuinceDbContext())
            {
                //Entity Framework ce po id-ju naci feedback i azurirati ga
                _context.Update(FeedbackMapper.MapFeedbackEntityToFeedbackPersistence(entity));
                _context.SaveChanges(); //moramo sacuvati promene
            }
        }
    }
}