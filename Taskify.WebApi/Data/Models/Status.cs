using Taskify.WebApi.Controllers;

namespace Taskify.WebApi.Data.Models;

public sealed class Status : AuditableEntity
{
    public required string Name { get; set; }
    public bool IsSystem { get; set; }

    public override void MarkAsDeleted()
    {
        if (IsSystem)
        {
            // Throw exception, stating only non-system status can be deleted.
        }

        base.MarkAsDeleted();
    }
}
