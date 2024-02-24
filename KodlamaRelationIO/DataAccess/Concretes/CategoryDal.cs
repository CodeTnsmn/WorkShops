using KodlamaRelationIO.DataAccess.Abstracts;
using KodlamaRelationIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaRelationIO.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal() 
        {
            Category category1 = new Category();
            category1.CategoryId = 1;
            category1.CategoryName = "Tümü";
            category1.CourseId = 1;

            Category category2 = new Category();
            category2.CategoryId = 2;
            category2.CategoryName = "Programlama";
            category2.CourseId = 2;

            categories=new List<Category> {category1,category2};

        }
        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            categories.Remove(category);
        }

        public List<Category> GetAll()
        {
           return categories;
        }

        public void Update(Category category)
        {
            Console.WriteLine("Kategori güncellendi.");
        }
    }
}
