using System;
using System.Text;
using System.Threading;

namespace Chapter6.ThreadPools.PoolLib
{
    public class ThreadList
    {

        StringBuilder messages = new StringBuilder();

        public StringBuilder ProcessPool()
        {
            for (int i=0; i<5; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Process));
            }

            for (int k=0; k<10; k++)
            {
                messages.AppendLine($"Main Thread - {k + 1}");
            }

            return messages;
        }

        private void Process(object callback)
        {
            for (int j=0; j<10; j++)
            {
                messages.AppendLine($"Thread - {j + 1}");
            }
        }
    }
}
