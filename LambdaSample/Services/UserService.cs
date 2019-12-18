using LambdaSample.Models;
using System;
using System.Collections.Generic;

namespace LambdaSample.Services
{
	public class UserService : IUserService
	{
		private readonly List<User> _users = new List<User>();
		
		public List<User> GetAll()
		{
			return _users;
		}

		public User AddUser(string name)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentNullException(nameof(name));
			}

			var user = new User(name);
			_users.Add(user);

			return user;
		}

		public User GetUser(Guid id)
		{
			return _users.Find(k => k.Id == id);
		}
	}
}
