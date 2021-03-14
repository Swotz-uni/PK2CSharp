using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Test
{
    class AndereKlasse
    {
        public delegate void MyDelegate(string Text);
        public event MyDelegate delegateEvent;
        public void triggerEvent(int low, int high,int n)
        {
            Random r = new Random();
            int delay = r.Next(low, high);

            for (int i = 0; i < n; i++)
            {
                Thread.Sleep(delay*1000);
                if (delegateEvent != null)
                {
                    delegateEvent(String.Format("Event zum {0}. Mal getriggert.", i + 1));
                }
            }
        }
    }
}
