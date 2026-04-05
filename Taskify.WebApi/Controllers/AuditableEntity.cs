using Taskify.WebApi.Data.Models;

namespace Taskify.WebApi.Controllers;

public abstract class AuditableEntity : BaseEntity
{
    public int? CreatedBy { get; set; }
    public  DateTimeOffset CreateAt { get; set; }
    public int? LastUpdatedBy { get; set; }
    public DateTimeOffset LastUpdatedAt { get; set; }
}
