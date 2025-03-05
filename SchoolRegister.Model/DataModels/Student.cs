using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using SchoolRegister.Model.DataModels;


namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public double AverageGrade { get; set; }
        public IDictionary<string, double> AverageGradePerSubject { get; set; }
        public IList<Grade> Grades { get; set; }
        public IDictionary<string, List<GradeScale>> GradesPerSubject { get; set; }
        public Group Group { get; set; }
        public int? GroupId { get; set; }
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }
    }
}
