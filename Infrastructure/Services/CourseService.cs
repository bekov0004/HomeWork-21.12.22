using Domain.Models;

namespace Infrastructure.Services;

public class CourseService
{
    public List<Course> courses;
    public CourseService()
    {
        courses = new List<Course>();
    }


    public List<Course> GetCourses()
    {
        return courses;
    }
    public void AddCourses(Course course)
    {
        courses.Add(course);
    }   

    public void UpdateCourses(Course course)
    {
        var find = courses.FirstOrDefault(x => x.Id == course.Id);
        find.Id = course.Id;
        find.Fee = course.Fee;
        find.Description = course.Description;
    }
    public void Delete(int id)
    {
        var find = courses.FirstOrDefault(x => x.Id == id);
        courses.Remove(find);
    }
}
