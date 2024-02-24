using KodlamaRelationIO.DataAccess.Abstracts;
using KodlamaRelationIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaRelationIO.DataAccess.Concretes
{
    internal class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal() 
        { 
            Instructor ınstructor1 = new Instructor();
            ınstructor1.InstructorId = 1;
            ınstructor1.FirstName = "Engin";
            ınstructor1.LastName = "Demiroğ";

            Instructor ınstructor2 = new Instructor();
            ınstructor2.InstructorId = 2;
            ınstructor2.FirstName = "Halit Enes";
            ınstructor2.LastName = "Kalaycı";

            instructors = new List<Instructor> { ınstructor1, ınstructor2 };
        
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine("Eğitmen güncellendi.");
        }
    }
}
