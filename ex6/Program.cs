﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int receptionTimeInMinutes = 10;
            int minutesInHour = 60;
            Console.Write("Кол-во людей в очереди: ");
            int peopleCount = Convert.ToInt32(Console.ReadLine());

            int totalMinutes = receptionTimeInMinutes * peopleCount;
            int waitingHours = totalMinutes / minutesInHour;
            int waitingMinutes = totalMinutes % minutesInHour;

            Console.WriteLine($"Вы должны простоять в очереди {waitingHours} часа {waitingMinutes} минут");

        }
    }
}
