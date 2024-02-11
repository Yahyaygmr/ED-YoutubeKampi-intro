using intro.DataAccess.Abstracts;
using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {

            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C# kursu";
            course1.Description = "Sıfırdan Zirveye C#";
            course1.Price = 59.99;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java";
            course2.Description = "Sıfırdan Zirveye Java";
            course2.Price = 59.99;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "Python";
            course3.Description = "Sıfırdan Zirveye Python";
            course3.Price = 59.99;

            courses = new List<Course> { course1, course2, course3 };
        }
        public List<Course> GetAll()
        {
            //burada db işlemleri yapılır
            return courses;
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }
    }
}



