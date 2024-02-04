using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business
{
    public class CourseManager
    {
        Course[] courses = new Course[3];
        public CourseManager()
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

            courses[0] = course1;
            courses[1] = course2;
            courses[2] = course3;

            //Course[] courses = { course1, course2, course3,
            //new Course(){Id = 4, Name="Sql Eğitimi", Description="Sıfırdan Zirveye", Price= 56.99}
            //};
        }
        public Course[] GetAll()
        {
            return courses;
        }
    }
}
