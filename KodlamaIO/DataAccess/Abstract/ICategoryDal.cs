using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstract;

public interface ICategoryDal
{
    void Add(Category category);
    void Delete(Category category);
    public List<Category> GetAll();
    void Update(Category category);

}
