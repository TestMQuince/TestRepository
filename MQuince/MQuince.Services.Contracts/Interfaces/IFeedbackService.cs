using MQuince.Services.Contracts.DTO;
using MQuince.Services.Contracts.IdentifiableDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MQuince.Services.Contracts.Interfaces
{
        public interface IFeedbackService : IService<FeedbackDTO, IdentifiableDTO<FeedbackDTO>>
        {
            IEnumerable<IdentifiableDTO<FeedbackDTO>> GetByStatus(bool publish);
            IEnumerable<IdentifiableDTO<FeedbackDTO>> GetByAllParams(bool publish, bool anonymous, bool approved);
        }
    
}
