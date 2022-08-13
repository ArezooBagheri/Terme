using System.Collections.Generic;
using Terme.Core.Domain.Masters.Entities;
using Terme.Core.Domain.Masters.Queries;
using Terme.Core.Domain.Masters.Repositories;
using Terme.Framework.Queries;

namespace Terme.Core.ApplicationServices.Masters.Queries
{
    public class AllMasterQueryHandler : IQueryHandler<AllMasterQuery, List<Master>>
    {
        private readonly IMasterQueryRepository masterQueryRepository;

        public AllMasterQueryHandler(IMasterQueryRepository masterQueryRepository)
        {
            this.masterQueryRepository = masterQueryRepository;
        }
        public List<Master> Handle(AllMasterQuery query)
        {
            return masterQueryRepository.GetAll();
        }
    }
}
