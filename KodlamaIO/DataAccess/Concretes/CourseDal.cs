using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concretes
{
    public class CourseDal:ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.CourseName = "Java";
            course1.CourseDescription = "Java ile sıfırdan ileri seviye OOP";

            Course course2 = new Course();
            course2.Id = 2;
            course2.CourseName = "Python";
            course2.CourseDescription = "Python - Selenium ile yazılım testi";

            Course course3 = new Course();
            course3.Id = 3;
            course3.CourseName = "C#";
            course3.CourseDescription = "C# ile .Net 8";

            Course course4 = new Course();
            course4.Id = 4;
            course4.CourseName = "JavaScript";
            course4.CourseDescription = "JavaScript ile web programlamanın temelleri";

            _courses = new List<Course> {course1, course2, course3, course4};
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(int id)
        {
            Console.WriteLine("Kurs Silindi.");
        }

        public void Update(Course course)
        {
            Console.WriteLine("Kurs Güncellendi.");
        }


    }
}
