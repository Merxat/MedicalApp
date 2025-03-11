using System.ComponentModel.DataAnnotations;

namespace Medical.Core.Comman
{
    public abstract class BaseEntity
    {
    public Guid Id { get; set; }
    }

}
