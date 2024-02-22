using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concrete;

public class InstructorDal : IInstructorDal
{
    public void Add(Instructor instructor)
    {
        Console.WriteLine("Veritabanına eğitmen eklendi");
    }

    public void Delete(Instructor instructor)
    {
        Console.WriteLine("Veritabanından eğitmen silindi");
    }

    public List<Instructor> GetAll()
    {
        List<Instructor> instructors = new List<Instructor>();
        return instructors;
    }

    public void Update(Instructor instructor)
    {
        Console.WriteLine("Veritabanındaki eğitmen güncellendi");
    }
}
