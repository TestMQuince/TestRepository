﻿using MQuince.Entities;
using MQuince.Repository.SQL.PersistenceEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MQuince.Repository.SQL.DataProvider.Util
{
    public class FeedbackMapper
    {
        public static Feedback MapFeedbackPersistenceToFeedbackEntity(FeedbackPersistence feedback)
        {
            if (feedback == null) return null;

            return new Feedback(feedback.Id, feedback.Comment, feedback.UserId, feedback.Anonymous, feedback.Publish);

        }

        public static FeedbackPersistence MapFeedbackEntityToFeedbackPersistence(Feedback feedback)
        {
            if (feedback == null) return null;

            FeedbackPersistence retVal = new FeedbackPersistence() { Id = feedback.Id, UserId = feedback.UserId,  Comment = feedback.Comment, Anonymous = feedback.Anonymous, Publish = feedback.Publish };
            return retVal;
        }

        public static IEnumerable<Feedback> MapFeedbackPersistenceCollectionToFeedbackEntityCollection(IEnumerable<FeedbackPersistence> clients)
            => clients.Select(c => MapFeedbackPersistenceToFeedbackEntity(c));
    }
}
