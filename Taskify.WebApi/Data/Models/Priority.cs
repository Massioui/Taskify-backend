using Taskify.WebApi.Controllers;

namespace Taskify.WebApi.Data.Models;

public sealed class Priority : AuditableEntity
{
    public string Name { get; private set; }
    public bool IsSystem { get; private set; }

    private Priority()
    { }

    public static Priority Create(string name, bool isSystem = false)
    {
        // Domain validation against invalid name
        var newPriority = new Priority
        {
            Name = name,
            IsSystem = isSystem
        };

        return newPriority;
    }

    public void Rename(string name)
    {
        // Domain validation against invalid name
        Name = name;
    }

    public override void MarkAsDeleted()
    {
        if (IsSystem)
        {
            // Throw exception, stating only non-system status can be deleted.
        }

        base.MarkAsDeleted();
    }
}
