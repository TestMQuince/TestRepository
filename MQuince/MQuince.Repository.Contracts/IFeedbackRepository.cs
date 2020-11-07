using MQuince.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MQuince.Repository.Contracts
{
    public interface IFeedbackRepository : IRepository<Feedback>
    {
        IEnumerable<Feedback> GetByStatus(bool publish);
        IEnumerable<Feedback> GetByAllParams(bool publish, bool anonymous, bool approved);
    }
}
