using System;
using System.Threading.Tasks;
using System.Timers;

namespace TimerTest
{
    class Program
    {
        public static int TimeInSeconds { get; private set; }
        public Timer CustomTimer { get; private set; } 

        static async Task Main(string[] args)
        {
            Console.Write("How long do you want me to wait for?: ");
            TimeInSeconds = int.Parse(Console.ReadLine());
            var timeToTrigger = TimeInSeconds * 1000; // Time to exit in milliseconds 1000ms per second so => 10 seconds = 10 * 1000 milliseconds.
            var Timer = new Timer(timeToTrigger)
            {
                AutoReset = false,
                Enabled = true
            };
            Console.WriteLine($"I've set a timer for {TimeInSeconds} seconds");
            Timer.Elapsed += HandleTimeout; // Method will trigger when timer ends and it sends the "Elapsed" trigger. 
            await Task.Delay(-1);
        }

        private static void HandleTimeout(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"I've waited {TimeInSeconds} seconds!");
        }
    }
}
