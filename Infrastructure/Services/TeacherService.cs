using Domain.Models;

namespace Infrastructure.Services;

public class TeacherService
{
    public List<Teacher> teachers;
    public List<Teacher> GetTeacher()
    {
        return teachers;
    }
    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }
    public void UpdateTeacher(Teacher teacher)
    {
        var find = teachers.FirstOrDefault(x => x.Id == teacher.Id);
        find.LastName = teacher.LastName;
        find.Position = teacher.Position;
        find.FirstName = teacher.FirstName;
    }
     public void Delete(int id)
    {
        var find = teachers.FirstOrDefault(x => x.Id == id);
        teachers.Remove(find);
    }
  

}
