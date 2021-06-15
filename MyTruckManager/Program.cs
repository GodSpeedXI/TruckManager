using MyTruckManager.Objects;
using MyTruckManager.Persons;
using System;
using System.IO.Compression;
using System.Timers;

namespace MyTruckManager
{
    class Program
    {
        private static RedTruck RedTruck { get; set; } = new RedTruck();
        private static Driver Driver { get; set; } = new Driver();
        private static Cleaner Cleaner { get; set; } = new Cleaner();
        private static Maintainer Maintainer { get; set; } = new Maintainer();
        static void Main(string[] args)
        {

            Timer _timer = new Timer(1000);
            _timer.Elapsed += _timer_Elapsed;
            _timer.Elapsed += _test_enlapsed;
            _timer.Start();

            Console.ReadLine();
        }

        private static void _test_enlapsed(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            Driver.DriveATruck(RedTruck);
            Cleaner.CleanATruck(RedTruck);
            Maintainer.FixATruck(RedTruck);
        }


    }
}
