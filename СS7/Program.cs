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
            int hour = 60;
            int min = 60;
            Console.Write("Введите кол-во людей в очереди: ");
            peopleLine = Convert.ToInt32(Console.ReadLine());
            waitingTime = peopleLine * doctorSession;
            hour = waitingTime / hour;
            min = waitingTime % min;
            Console.WriteLine("Вы должны отстоять в очереди: " + hour + " часа и " + min + " мин");
        }
    }
}