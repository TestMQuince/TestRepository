using MQuince.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MQuince.Repository.Contracts
{
    public interface IFeedbackRepository : IRepository<Feedback>
    {
<<<<<<< HEAD
        IEnumerable<Feedback> GetByStatus(bool publish, bool approved);
        IEnumerable<Feedback> GetByParams(bool anonymous, bool approved);
=======
        IEnumerable<Feedback> GetByStatus(bool publish);
        IEnumerable<Feedback> GetByAllParams(bool publish, bool anonymous, bool approved);
>>>>>>> develop
    }
}
