using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Blog.BlazorApp.ViewModels.Posts;
public class AddPostViewModel
{
    [Required]
    public string Body { get; set; }
    [Required]
    [MaxLength(250)]
    public string Title { get; set; }
    [Required]
    [MaxLength(80)]
    public string Slug { get; set; }
    [Required]
    public IFormFile File { get; set; }
}
