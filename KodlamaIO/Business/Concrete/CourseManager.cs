using KodlamaIO.Business.Abstract;
using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Concrete;

public class CourseManager : ICourseManager
{
    private readonly ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete();
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Update(Course course)
    {
        _courseDal.Update();    
    }
}
