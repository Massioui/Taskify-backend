using Microsoft.AspNetCore.Mvc;

namespace Taskify.WebApi.Controllers;

[ApiController]
[Produces("application/json")]
public abstract class ApiControllerBase : ControllerBase
{ }