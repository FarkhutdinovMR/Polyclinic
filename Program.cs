using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    class Program
    {
        static void Main(string[] args)
        {
            int timePerPatient = 10;
            int patientCount;

            Console.Write("Введите количество пациентов в очереди: ");
            patientCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Вы должны отстоять в очереди {patientCount * timePerPatient / 60} часа и {patientCount * timePerPatient % 60} минут.");
        }
    }
}