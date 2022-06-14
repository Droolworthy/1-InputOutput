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
            int waitingHour = 60;
            int waitingMinute = 60;
            Console.Write("Введите кол-во людей в очереди: ");
            peopleLine = Convert.ToInt32(Console.ReadLine());
            waitingTime = peopleLine * doctorSession;
            waitingHour = waitingTime / waitingMinute;
            waitingMinute = waitingTime % waitingMinute;
            Console.WriteLine("Вы должны отстоять в очереди: " + waitingHour + " час и " + waitingMinute + " мин");
        }
    }
}
