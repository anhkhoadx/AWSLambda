using LambdaSample.Models;
using System;
using System.Collections.Generic;

namespace LambdaSample.Services
{
	public interface IUserService
	{
		List<User> GetAll();

		User AddUser(string name);

		User GetUser(Guid id);
	}
}