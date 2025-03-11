using System.ComponentModel.DataAnnotations;

namespace Medical.Core.Comman
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
