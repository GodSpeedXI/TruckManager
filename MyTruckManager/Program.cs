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
        
        private static BlueTruck BlueTruck { get; set; } = new BlueTruck();
        private static Driver Driver { get; set; } = new Driver();
        private static Cleaner Cleaner { get; set; } = new Cleaner();
        private static Maintainer Maintainer { get; set; } = new Maintainer();
        static void Main(string[] args)
        {

            Timer _red_timer = new Timer(1000);
            _red_timer.Elapsed += _red_Elapsed;
            _red_timer.Elapsed += _blue_enlapsed;
            _red_timer.Start();
            
            // Timer _blue_timer = new Timer(1000);
            // _blue_timer.Elapsed += _blue_enlapsed;
            // _blue_timer.Start();

            Console.ReadLine();
        }

        private static void _blue_enlapsed(object sender, ElapsedEventArgs e)
        {
            //Console.Clear();
            Driver.DriveATruck(BlueTruck);
            Cleaner.CleanATruck(BlueTruck);
            Maintainer.FixATruck(BlueTruck);
        }

        private static void _red_Elapsed(object sender, ElapsedEventArgs e)
        {
            //Console.Clear();
            Driver.DriveATruck(RedTruck);
            Cleaner.CleanATruck(RedTruck);
            Maintainer.FixATruck(RedTruck);
        }


    }
}
