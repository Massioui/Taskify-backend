using Taskify.WebApi.Controllers;

namespace Taskify.WebApi.Data.Models;

public sealed class Task : AuditableEntity
{
    public required string Title { get; set; }
    public DateTimeOffset? DueDateTime { get; set; }
    public string? Description { get; set; }
    public string? AssetPath { get; set; }

    public int PriorityId { get; set; }
    public Priority Priority { get; set; } = default!;
}
