using Microsoft.AspNetCore.SignalR;

namespace BasicMVC.Models
{

    public class Comment{

        public int Id{get; set;}
 
 public DateTime CreateDate{get; set;} 

public DateTime EditDate{get; set;}

public string CommentText{get; set;} = string.Empty;

public string OwnerId{get; set;} = string.Empty;

public MVCUser Owner {get; set;} = null;

public int PostIdNumber  {get; set;} 

public Post Post {get; set;} = null;
}
}


