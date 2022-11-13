#region Before
using System;
using System.Security.Cryptography;

//public interface IMessage
//{
//    IList<string> ToAddress { get; set; }
//    IList<string> BccAddresses { get; set; }
//    string MessageBody { get; set; }
//    string Subject { get; set; }
//    bool Send();
//}

//public class SmtpMessage : IMessage
//{
//    public IList<string> ToAddress { get; set; }
//    public IList<string> BccAddresses { get; set; }
//    public string MessageBody { get; set; }
//    public string Subject { get; set; }
//    public bool Send()
//    {
//        // Code for sending E-mail.
//        return false;
//    }
//}

//public class SmsMessage : IMessage
//{
//    public IList<string> ToAddress { get; set; }
//    public IList<string> BccAddresses
//    {
//        get { throw new NotImplementedException(); }
//        set { throw new NotImplementedException(); }
//    }
//    public string MessageBody { get; set; }
//    public string Subject
//    {
//        get { throw new NotImplementedException(); }
//        set { throw new NotImplementedException(); }
//    }
//    public bool Send()
//    {
//        // Code for sending SMS.
//        return false;
//    }
//}

#endregion

//In the SmsMessage we don’t require BccAddresses and Subject, but we are forced to implement it because of IMessage interface.
//So it violates the ISP principle.


#region After
//public interface IMessage
//{
//    bool Send(IList<string> toAddress, string messageBody);
//}

//public interface IEmailMessage : IMessage
//{
//    string Subject { get; set; }
//    IList<string> BccAddresses { get; set; }
//}

//public class SmtpMessage : IEmailMessage
//{
//    public IList<string> BccAddresses { get; set; }
//    public string Subject { get; set; }
//    public bool Send(IList<string> toAddress, string messageBody)
//    {
//        // Code for sending E-mail.
//        return false;
//    }
//}

//public class SmsMessage : IMessage
//{
//    public bool Send(IList<string> toAddress, string messageBody)
//    {
//        // Code for sending SMS.
//        return false;
//    }
//}


#endregion

//SmsMessage needs only toAddress and messageBody,
//so now we can utilise IMessage interface to avoid unnecessary implementation.