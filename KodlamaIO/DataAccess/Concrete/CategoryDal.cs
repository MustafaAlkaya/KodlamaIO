using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concrete;

public class CategoryRepository : ICategoryDal
{
    public void Add(Category category)
    {
        Console.WriteLine("Veritabanına kategori eklendi");
    }

    public void Delete(Category category)
    {
        Console.WriteLine("Veritabanından kategori silindi");
    }

    public List<Category> GetAll()
    {
        List<Category> categories = new List<Category>();
        return categories;
    }

    public void Update(Category category)
    {
        Console.WriteLine("Veritabanındaki kategori güncellendi");
    }
}
