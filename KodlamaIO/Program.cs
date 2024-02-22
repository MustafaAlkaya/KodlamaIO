using KodlamaIO.Business.Concrete;
using KodlamaIO.DataAccess.Concrete;
using KodlamaIO.Entities;

CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();

foreach (Course course in courses)
{
    Console.WriteLine(course.CourseName);
}

courseManager.Add(new Course());


InstructorManager instructorManager = new(new InstructorDal());
instructorManager.Add(new Instructor());
instructorManager.Update(new Instructor());



