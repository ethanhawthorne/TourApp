using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourApp.Shared;

namespace TourApp.Client.Pages
{
	[Authorize]
	public class UserModel : PageModel
	{

		public UserModel(UserManager<Users> userManager)
		{
			this.UserManager = userManager;
		}
		public Users? appUser;
		// I think the issue with the page is that your only logged in when on log in/logout page and when your at index page your not logged in thats why the page doesnt display
		// dont know if the below line breaks the thing but it took away the user manager errors
		public UserManager<Users> UserManager { get; }

		public void OnGet()
		{
			var task = UserManager.GetUserAsync(User);
			task.Wait();
			appUser = task.Result;

		}
	}
}
