using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserDto:IDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
    }
}
