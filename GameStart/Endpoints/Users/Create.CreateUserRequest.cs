﻿namespace GameStart.Endpoints.Users
{
    public class CreateUserRequest : BaseRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}