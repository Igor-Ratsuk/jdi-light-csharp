﻿using JDI.Light.Attributes;

namespace JDI.Light.Tests.Entities
{
    public class User
    {
        public static readonly User DefaultUser = new User("epam", "1234");

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        [Name("LoginField")]
        public string Login;

        [Name("Password")]
        public string Password { get; set; }
    }
}