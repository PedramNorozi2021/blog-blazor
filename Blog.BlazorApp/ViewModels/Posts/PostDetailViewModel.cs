namespace Blog.BlazorApp.ViewModels.Posts;
public class PostDetailViewModel : PostViewModel
{
    public List<PostCommentViewModel> Comments { get; set; }
}

public class PostCommentViewModel
{
    public string UserName { get; set; }
    public string Text { get; set; }
    public string CreateDate { get; set; }
}
