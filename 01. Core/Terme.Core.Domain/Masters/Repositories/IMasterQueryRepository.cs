using System.Collections.Generic;
using Terme.Core.Domain.Masters.Entities;

namespace Terme.Core.Domain.Masters.Repositories
{
    public interface IMasterQueryRepository
    {
        List<Master> GetAll();
    }
}
