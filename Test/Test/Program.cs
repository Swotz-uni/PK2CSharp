using System;
using System.IO;
using System.Threading;

namespace Test
{
    class Program
    {

        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            AndereKlasse ak = new AndereKlasse();

            ak.delegateEvent += DelegateEventHandler;
            ak.delegateEvent += WriteLog;
            ak.zweites += WriteLog;

            ak.triggerEvent(0, 0, 100);
        }

        //static void Main(string[] args)
        //{
        //    MyDelegate del = A;
        //    del = (MyDelegate)Delegate.Combine(del, (MyDelegate)B);
        //    del += B;
        //    del = (MyDelegate)Delegate.Remove(del, (MyDelegate)B);
        //    del += B;
        //    del += B;
        //    del += B;
        //    del += B;
        //    del += B;
        //    del += Space;
        //    del();

        //    del = (MyDelegate)Delegate.RemoveAll(del, (MyDelegate)B);

        //    del();
        //}
        static void A()
        {
            Console.WriteLine("A");
        }

        static void B()
        {
            Console.WriteLine("B");
        }

        static void C()
        {
            Console.WriteLine("C");
        }

        static void D()
        {
            Console.WriteLine("D");
        }

        static void E()
        {
            Console.WriteLine("E");
        }

        static void F()
        {
            Console.WriteLine("F");
        }

        static void Space()
        {
            Console.WriteLine("");
        }
        public static void DelegateEventHandler(string text)
        {
            Console.WriteLine(text);
        }
        public static String GetTimestamp(DateTime value)
        {
            //return value.ToString("yyyy-MM-dd HH:mm:ss");
            return value.ToString("dd-MM-yyyy HH:mm:ss");
        }

        public static void WriteLog(string text)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            using StreamWriter file = new("C:\\Users\\svens\\Source\\Repos\\Swotz-uni\\PK2CSharp\\Test\\Test\\Log.txt", append: true);
            file.WriteLineAsync(timeStamp + " " + text);
            //File.WriteAllTextAsync("WriteText.txt", text);
        }


    }

}
