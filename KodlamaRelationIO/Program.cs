// See https://aka.ms/new-console-template for more information
using KodlamaRelationIO.Business;
using KodlamaRelationIO.DataAccess.Concretes;
using KodlamaRelationIO.Entities;

CourseManager courseManager = new CourseManager(new CourseDal());

List<Course> courses = courseManager.GetAll();

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].CourseName);
}
