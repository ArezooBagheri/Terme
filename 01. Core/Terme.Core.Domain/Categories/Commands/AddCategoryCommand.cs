using Terme.Framework.Commands;

namespace Terme.Core.Domain.Categories.Commands
{
    public class AddCategoryCommand : ICommand
    {
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public string PhotoUrl { get; set; }
        public int PhotoSize { get; set; }
    }
}
