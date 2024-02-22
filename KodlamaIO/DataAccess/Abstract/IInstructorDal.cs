using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Delete(Instructor instructor);
        public List<Instructor> GetAll();
        void Update(Instructor instructor);
    }
}
