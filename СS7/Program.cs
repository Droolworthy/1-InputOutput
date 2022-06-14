using System;

namespace СS7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleLine;
            int doctorSession = 10;
            int waitingTime;
            int waitingHour;
            int waitingMinute;
            int minutesHour = 60;
            Console.Write("Введите кол-во людей в очереди: ");
            peopleLine = Convert.ToInt32(Console.ReadLine());
            waitingTime = peopleLine * doctorSession;
            waitingHour = waitingTime / minutesHour;
            waitingMinute = waitingTime % minutesHour;
            Console.WriteLine("Вы должны отстоять в очереди: " + waitingHour + " час и " + waitingMinute + " мин");
        }
    }
}
