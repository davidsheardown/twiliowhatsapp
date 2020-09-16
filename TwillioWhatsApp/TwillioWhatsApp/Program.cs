using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


namespace TwillioWhatsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello WhatsApp");

            
            const string accountSid = "AC560a06f30b769f7273622fd45217f7ed";
            const string authToken = "45ac020fb0a29234b8eeb041820a7c8b";


            TwilioClient.Init(accountSid, authToken);


            var message = MessageResource.Create(
                from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
                body: "Blimey! WhatsApp from C#",
                //to: new Twilio.Types.PhoneNumber("whatsapp:+447309091478")
                to: new Twilio.Types.PhoneNumber("whatsapp:+447446335073")
            );


            Console.WriteLine("Message response: {0}", message.Sid);
            Console.ReadLine();
        }
    }
}
