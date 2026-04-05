using Taskify.WebApi.Controllers;

namespace Taskify.WebApi.Data.Models;

public sealed class User : AuditableEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public string? Phone { get; set; }
    public string? Position { get; set; }
    public string? AvatarPath { get; set; }
}
