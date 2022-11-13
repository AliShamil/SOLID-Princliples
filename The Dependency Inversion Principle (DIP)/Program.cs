#region Before

//public class Email
//{
//    public string ToAddress { get; set; }
//    public string Subject { get; set; }
//    public string Content { get; set; }
//    public void SendEmail()
//    {
//        //Send email
//    }
//}

//public class SMS
//{
//    public string PhoneNumber { get; set; }
//    public string Message { get; set; }
//    public void SendSMS()
//    {
//        //Send sms
//    }
//}

//public class Notification
//{
//    private Email _email;
//    private SMS _sms;
//    public Notification()
//    {
//        _email = new Email();
//        _sms = new SMS();
//    }

//    public void Send()
//    {
//        _email.SendEmail();
//        _sms.SendSMS();
//    }
//}

#endregion

//Notice that a higher-level class, the Notification class,
//has a dependency on both the Email class and the SMS class, which are lower-level classes.
//Since DIP wants us to have both high and low-level classes depending on abstractions,
//we are currently violating the Dependency Inversion Principle.



#region After

//public interface IMessage
//{
//   public void SendMessage();
//}

//public class Notification
//{
//    private ICollection<IMessage> _messages;

//    public Notification(ICollection<IMessage> messages)
//    {
//        this._messages = messages;
//    }
//    public void Send()
//    {
//        foreach (var message in _messages)
//        {
//            message.SendMessage();
//        }
//    }
//}

#endregion

//Here we have allowed both high-level and low-level classes to rely on abstractions,
//thereby upholding the Dependency Inversion Principle.
