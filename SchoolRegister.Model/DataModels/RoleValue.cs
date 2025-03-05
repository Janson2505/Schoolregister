using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using SchoolRegister.Model.DataModels;


namespace SchoolRegister.Model.DataModels
{
    public enum RoleValue
    {
        User,
        Student,
        Parent,
        Teacher,
        Admin
    }
}