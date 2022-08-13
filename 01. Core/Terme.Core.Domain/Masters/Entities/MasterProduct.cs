using Terme.Core.Domain.Categories.Entities;
using Terme.Framework.Domain;

namespace Terme.Core.Domain.Masters.Entities
{
    public class MasterProduct : BaseEntity
    {
        public Master Master { get; set; }
        public long MasterId { get; set; }
        public Category Category { get; set; }
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public long Discount { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }

    }
}
