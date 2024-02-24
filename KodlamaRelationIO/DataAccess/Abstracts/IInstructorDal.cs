using KodlamaRelationIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaRelationIO.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);

        void Delete(Instructor instructor);

        void Update(Instructor instructor);

        List<Instructor> GetAll();


    }
}
