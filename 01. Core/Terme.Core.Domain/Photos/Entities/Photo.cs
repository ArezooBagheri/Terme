using Terme.Framework.Domain;

namespace Terme.Core.Domain.Photos.Entities
{
    public class Photo : BaseEntity
    {
        public string Url { get; set; }
        public int Size { get; set; }
    }
}
