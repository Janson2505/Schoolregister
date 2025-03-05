using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.Model.DataModels
{
    public class Parent : User
    {
        public IList<Student> Students { get; set; }
    }
}