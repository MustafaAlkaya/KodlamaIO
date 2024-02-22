using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.CourseId = 1;
            course1.CourseName = "C#";
            course1.InstructorId = 1;
            course1.CategoryId = 1;
            course1.Description = "Yazılım Geliştirici C# Kampı";


            Course course2 = new Course();
            course2.CourseId = 2;
            course2.CourseName = "Java + React";
            course2.InstructorId = 1;
            course2.CategoryId = 1;
            course2.Description = "Yazılım Geliştirici JAVA ve React Kampı";


            Course course3 = new Course();
            course3.CourseId = 3;
            course3.CourseName = "Python";
            course3.InstructorId = 2;
            course3.CategoryId = 2;
            course3.Description = "Yazılım Geliştirici Python Kampı";


            _courses = new List<Course> { course1, course2, course3 };
        }
        public void Add(Course course)
        {
            _courses.Add(course);
            Console.WriteLine("Kurs Başarıyla Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Silindi.");
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update()
        {
            Console.WriteLine("Güncellendi.");
        }
    }
}
