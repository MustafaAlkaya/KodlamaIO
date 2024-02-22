using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Abstract;

public interface ICourseManager
{
    void Add(Course course);
    void Delete(Course course);
    List<Course> GetAll();
    void Update(Course course);
}
