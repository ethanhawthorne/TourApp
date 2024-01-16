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

namespace TourApp.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthStateController : ControllerBase
{
	private readonly DbContext _context;
	private readonly UserManager<Users> _userManager;
	private readonly SignInManager<Users> _signInManager;



	public AuthStateController(DbContext context, UserManager<Users> userManager, SignInManager<Users> signInManager)
	{
		_context = context;
		_userManager = userManager;
		_signInManager = signInManager;
	}

	[HttpGet]
	public async Task<ActionResult<String>> GetAuthState()
	{
		if (_signInManager.IsSignedIn(User))
		{


			var userDict = new Dictionary<String, String>()
			{
				{ "userId", _userManager.GetUserId(User) },
				{ "userName", _userManager.GetUserName(User) }
			};


			return Ok(userDict);

		}
		return Ok("User is not signed in.");
	}

}
