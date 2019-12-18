using LambdaSample.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LambdaSample.Controllers
{
	[Route("api/[controller]")]
    public class UsersController : Controller
    {
		private readonly IUserService _userService;

		public UsersController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet]
		public IActionResult GetAllUsers()
		{
			return Ok(_userService.GetAll());
		}

		[HttpGet]
		[Route("{id}")]
		public IActionResult GetUser(Guid id)
		{
			var user = _userService.GetUser(id);

			if (user == null)
			{
				return BadRequest(nameof(user));
			}

			return Ok(user);
		}

		[HttpPost]
		public IActionResult AddUser([FromBody] string name)
		{
			var user = _userService.AddUser(name);

			return Ok(user);
		}
	}
}
