using KodlamaIO.Business;
using KodlamaIO.DataAccess.Concretes;
using KodlamaIO.Entities;



CourseManager courseManager = new(new CourseDal());

List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine("Kursun adı: " + courses[i].CourseName + " /" + " Kursun açıklaması: " + courses[i].CourseDescription);
}
courseManager.Delete(3);


Console.WriteLine("*******************************************");


CategoryManager categoryManager = new(new CategoryDal());
List<Category> categories = categoryManager.GetAll();
for (int i = 0;i < categories.Count; i++)
{
    Console.WriteLine("Kategori İsmi: " + categories[i].CategoryName);
}


Console.WriteLine("*******************************************");


InstructorManager instructorManager = new(new InstructorDal());
List<Instructor> instructors = instructorManager.GetAll();
for (int i = 0;i<instructors.Count; i++)
{
    Console.WriteLine("Eğitmen: " + instructors[i].FirstName + " " + instructors[i].LastName);
}

Console.ReadLine();