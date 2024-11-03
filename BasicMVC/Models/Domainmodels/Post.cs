using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace BasicMVC.Models
{
 public class Post{

 public int Id {get; set;}
 
 public DateTime CreateDate { get; set; }

public DateTime EditDate {get; set;}

public string PostText {get; set;} = string.Empty;

public string OwnerId{get; set;} = string.Empty;

        public MVCUser Owner { get; set; } = null;

        public ICollection<Comment> Comments{ get; set; } = new HashSet<Comment>();

}}
