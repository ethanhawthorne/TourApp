using System.Collections;
using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using TourApp.Server.data;
using TourApp.Shared;
using String = System.String;

namespace PacificTours.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
	private readonly DbContext _context;
	private readonly UserManager<User> _userManager;
	private readonly SignInManager<User> _signInManager;

	public AuthController(DbContext context, UserManager<User> userManager, SignInManager<User> signInManager)
	{
		_context = context;
		_userManager = userManager;
		_signInManager = signInManager;
	}

	[HttpGet]
	// public async Task<ActionResult<IEnumerable<Claim>>> GetAuthState()
	public async Task<ActionResult<String>> GetAuthState()
	{
		if (_signInManager.IsSignedIn(User))
		{
			// var json = JsonSerializer.Serialize(User.Claims, new JsonSerializerOptions()
			// {
			//     ReferenceHandler = ReferenceHandler.IgnoreCycles
			// });
			// return Ok(json);

			var userDict = new Dictionary<String, String>()
			{
				{ "userId", _userManager.GetUserId(User) },
				{ "userName", _userManager.GetUserName(User) }
			};


			return Ok(userDict);
			// return Ok(_userManager.GetUserName(User));

		}
		return Problem("User is not signed in.");
	}

}
