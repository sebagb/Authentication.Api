using Authentication.Api.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Api.Controllers;

public class AuthController : ControllerBase
{
    [HttpGet("guest")]
    public IActionResult Guest()
    {
        return Ok("Welcome guest");
    }

    [HttpGet("trusted")]
    [Authorize(AuthConstants.TrustedMemberPolicyName)]
    public IActionResult Authorized()
    {
        return Ok("Welcome authorized trusted member");
    }

    [HttpGet("admin")]
    [Authorize(AuthConstants.AdminUserPolicyName)]
    public IActionResult Admin()
    {
        return Ok("Welcome authorized admin user");
    }
}