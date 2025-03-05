using Microsoft.AspNetCore.Identity;
using System;
using System.Data;

namespace SchoolRegister.Model.DataModels
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DataSetDateTime RegistrationDate { get; set;}
    }
}