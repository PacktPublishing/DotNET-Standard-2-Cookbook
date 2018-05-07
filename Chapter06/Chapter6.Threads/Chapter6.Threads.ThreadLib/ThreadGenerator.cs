using System;
using System.Text;
using System.Threading;


namespace Chapter6.Threads.ThreadLib
{
    public class ThreadGenerator
    {
        StringBuilder messages = new StringBuilder(); 

        public StringBuilder StartThreads()
        {
            
            var mainThread = Thread.CurrentThread;
            mainThread.Name = "MainThread";

            messages.Append($"This is the {mainThread.Name}\n");

            Thread anotherThread = new Thread(CountTo100);
            messages.Append("Start a new thread\n");

            anotherThread.Start();

            messages.Append($"Now call {mainThread.Name} will count to 50\n");

            for (int j=0; j<50; j++)
            {
                messages.Append($"MT-{j + 1}\n");
                Thread.Sleep(10);
            }

            messages.Append($"{mainThread.Name} finished\n");


            return messages;

        }

        private void CountTo100()
        {
            for (int i=0; i<100; i++)
            {
                messages.Append($"Thread 2 counting {i + 1}\n");
                Thread.Sleep(20);
            }
        }
    }
}
