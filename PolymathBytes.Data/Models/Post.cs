using System.Net.Mime;

namespace PolymathBytes.Data.Models;

using IdType = int;
using TitleType = string;
using ContentType = string; 

public class Post
{
    public IdType Id { get; set; }
    public TitleType Title { get; set; }
    public ContentType Content { get; set; }
    public DateTime Date { get; set; }
}