using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Terme.Core.Domain.Masters.Entities;
using Terme.Core.Domain.Masters.Repositories;

namespace Terme.Infrastructures.Data.SqlServer.Masters.Repositories
{
    public class MasterQueryRepository : IMasterQueryRepository
    {
        private readonly TermeDbContext _termeDbContext;

        public MasterQueryRepository(TermeDbContext termeDbContext)
        {
            _termeDbContext = termeDbContext;
        }
        public List<Master> GetAll()
        {
            return _termeDbContext.Masters.AsNoTracking().Include(c => c.Photo).ToList();
        }
    }
}
