using System;
using System.Globalization;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


namespace revision;
{
    class Journal
    {
        static void JournaRecordReminder(string[]args)
        {
            Console.WriteLine("These are what stop you from writing in your journal daily");
//            string numbers[] = new string[5] {"1. I forget", "2. Iam too bizy", "3.It's useless", "4. Idon't know how", "5. It's npne pf your business"};
            Console.Write  {" I forget", " Iam too bizy", "It's useless", " Idon't know how", " It's npne pf your business"};
            string numbers = "Mynumber.txt";
            string[] lines = System.IO.File.ReadAllLines(numbers);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string firstnumber = parts[0];
                string lastnumber = parts[4];
            }
            Console.WriteLine
            

            
            Console.WriteLine("Write a number related to why you dont write in it");
            string Reasons = Console.ReradLine();
            // Call for a while loop and a break point in case of irritations
        }

// create the function you will always use to invoke current time

        public static void Time(int)
        {
            import Time
            time = tim.now();
            return time 
            
        }        



        static int  SixHourReminder1(num)
        {
            startingTime(),
            firstHour + 5;
            {
                
            }
            
     
        }

        int SixHourlyReminder2(int)
        {
            Time();
        
            {
                Console.WriteLine("Bip!!!! Bip!!! It's time for journaling");
            }


        }

        public int SixHourlyReminder3(int)
        {
            Time();
            int currentTime = new int Time();
            // if condition which will awaken the alarm
            {
                Console.WriteLine("Bip!!!!1Bip!!! It's time for journaling");
            }
        }
    }

