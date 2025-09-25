using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.Controllers;

[Authorize]
public class BaseController : Controller
{

}
