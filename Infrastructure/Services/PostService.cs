using Domain.Models;

namespace Infrastructure.Services;

public class PostService
{

    public List<Post> posts;
    public PostService()
    {
        posts = new List<Post>();
    }


    public List<Post> GetStudents()
    {
        return posts;
    }
    public void AddPost(Post post)
    {
        posts.Add(post);
    }

    public void UpdateStudent(Post post)
    {
        var find = posts.FirstOrDefault(x => x.Id == post.Id);
        find.Id = post.Id;
        find.Title = post.Title;
        find.Description = post.Description;
    }
    public void Delete(int id)
    {
        var find = posts.FirstOrDefault(x => x.Id == id);
        posts.Remove(find);
    }
}
