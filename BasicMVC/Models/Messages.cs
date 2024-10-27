using System.Security.Cryptography.X509Certificates;

namespace BasicMVC.Models{

    public class Message{
        
    public int  MessageID {get; set;}  
        public string MessageText {get; set;} = string.Empty;
    }
}
