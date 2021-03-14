using System;
using System.IO;
using System.Threading;

namespace Test
{
    class Program
    {

        
        static void Main(string[] args)
        {
            AndereKlasse ak = new AndereKlasse();

            ak.delegateEvent += DelegateEventHandler;
            ak.delegateEvent += WriteLog;

            ak.triggerEvent(1,2,10);
        }

        public static void DelegateEventHandler(string text)
        {
            Console.WriteLine(text);
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static void WriteLog(string text)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            using StreamWriter file = new("C:\\Users\\svens\\source\\repos\\Test\\Test\\Log.txt", append: true);
            file.WriteLineAsync(timeStamp + " " + text);
            //File.WriteAllTextAsync("WriteText.txt", text);
        }

        //static void A()
        //{
        //    Console.WriteLine("A");
        //}

        //static void B()
        //{
        //    Console.WriteLine("B");
        //}

        //static void C()
        //{
        //    Console.WriteLine("C");
        //}

        //static void D()
        //{
        //    Console.WriteLine("D");
        //}

        //static void E()
        //{
        //    Console.WriteLine("E");
        //}

        //static void F()
        //{
        //    Console.WriteLine("F");
        //}

        //static void Space()
        //{
        //    Console.WriteLine("");
        //}
    }
            
}
