using ServiceReference1;
using SmsIrRestful;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ServiceReference1.SendReceiveSoapClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AustriaTime
{
    public class sms
    {
        public static void Send(string[] to)
        {

            //var token = new Token().GetToken("e5ab04c46dd63509d4a708bf", "");

            //var messageSendObject = new MessageSendObject()
            //{
            //    Messages = new List<string> { "اتریش باز شد"+"**** "+DateTime.Now }.ToArray(),
            //    MobileNumbers = to,
            //    LineNumber = "30002101004116",
            //    SendDateTime = null,
            //    CanContinueInCaseOfError = true
            //};

            //MessageSendResponseObject messageSendResponseObject = new MessageSend().Send(token, messageSendObject);

            //if (messageSendResponseObject.IsSuccessful)
            //{

            //}
            //else
            //{

            //}

           
        }


    }
}
