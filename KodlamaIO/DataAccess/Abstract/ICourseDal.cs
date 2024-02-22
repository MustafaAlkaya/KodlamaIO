using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstract;

public interface ICourseDal
{
    void Add(Course course);
    void Delete();
    List<Course> GetAll();
    void Update();
}
