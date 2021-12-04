using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Data;

internal sealed class Post
{
    [Key]
    public int PostId { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [MaxLength(5000)]
    public string Content { get; set; } = string.Empty;
}