using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Messages
{
    // базовый класс
    public class Message
    {
        public virtual void Send()
        {
            Console.WriteLine("Сообщение отправлено.");
        }
    }

    // класс Email
    public class Email : Message
    {
        public override void Send()
        {
            Console.WriteLine("Email отправлен!");
        }
    }

    // класс SMS
    public class SMS : Message
    {
        public override void Send()
        {
            Console.WriteLine("SMS отправлено!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Message[] messages = { new Email(), new SMS(), new Message() };

            foreach (var m in messages)
                m.Send();

            Console.ReadLine();
        }
    }
}
