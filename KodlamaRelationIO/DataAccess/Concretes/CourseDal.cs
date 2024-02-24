using KodlamaRelationIO.DataAccess.Abstracts;
using KodlamaRelationIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaRelationIO.DataAccess.Concretes
{
    internal class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            Course course1 = new Course();
            course1.CourseId = 1;
            course1.CourseName = "C#";
            course1.InstructorId = 1;

            Course course2 = new Course();
            course2.CourseId = 2;
            course2.CourseName = "JAVA";
            course2.InstructorId = 2;

            Course course3 = new Course();
            course3.CourseId = 3;
            course3.CourseName = "PYTHON";
            course3.InstructorId = 3;

            courses = new List<Course> {course1,course2,course3};   
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course course)
        {
            Console.WriteLine("Kurslar güncellendi.");
        }
    }
}
