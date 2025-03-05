using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using SchoolRegister.Model.DataModels;


namespace SchoolRegister.Model.DataModels
{
    public class Teacher : User
    {
        public string Title { get; set; }
        public IList<Subject> Subjects { get; set; }
    }
}