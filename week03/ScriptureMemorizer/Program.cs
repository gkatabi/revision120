using System;
using System.Text;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Concurrent;
using System.Reflection;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
namespace HelloWorld;

    class Scripture
    {
        public static void Memorizer()
        {

        }
            
            private string _book = "John"; 

            private int _chapter = 5 ;

            private static  string _numbers ;

        static void  JoinWords()
        {
            string[] Words; 
        

            
        }
            

        public string JoinNumbers(int first,int second,int third) 
            {
                string numbers  = first + ":" + second + ":" + third ;
                
                return numbers;

            }

    
        }
    public class HideDisplay
    
    {
        public static string  _Display()
        {
            return _book + _chapter + _numbers + _words;
        }
            public static string _book;
            public static int _chapter;
            public static string _numbers;
            

            private static string _words;

        private class  Hide
        {
            private List <string> _hidden = new List <string>();
            public void Replace(string msg)
            {
                _disappear = true;
            }
            
            
            string[] _Menu ={};
        private object _disappear;
    }

    
    
        private static string[] Words = {"After ","this ","there ", "was ", "a ","feast ","of ","the ","Jews ","and ",
            "Jesus ","went ","to ","Jerusalem " ,"Now ","there ", "is ", "at ","Jerusalem ", "by ","the ", "sheep ", "market ",
             "at ","pool ", "which ", "is ","called ", "in ","the ", "Hebrew ","tongue ", "Bethesida ", "having ",
             "five ", "porches "};   
        private static char[] result = _words.SkipLast(1).ToArray();

    

    
        

          
        public static void Main(string[] msg)
        {
            string[]_book = {"John"};
            string[]_chapter = {"5"};
            string[]_numbers = {"1-2"};


            string[] _words1 = { "After ","this ","there ", "was ", "a ","feast ","of ","the ","Jews ","and ",
            "Jesus ","went ","to ","Jerusalem "} ;                
                
            string[] _words2 = { "Now ","there ", "is ", "at ","Jerusalem ", "by ","the ", "sheep ", "market ",
             "at ","pool ", "which ", "is ","called ", "in ","the ", "Hebrew ","tongue ", "Bethesida ", "having ",
             "five ", "porches "};
            string[] Words = _words1.Concat(_words2).ToArray();
            string[] Words3 = (Words.SkipLast(1).ToArray());
            Console.WriteLine(Words3);
            for (int i = 0; i< Words3.Length; i++)
            {


                while (i < Words3.Length)
                {
                   Console.WriteLine("Press 4" );
                   string lead = Console.ReadLine();
                   int Lead = Convert.ToInt32(Console.ReadLine());
                   while (Lead > 0)
                   {
                    
                        Console.Write(Words3[i]);
                        Random rdm = new Random();
                        Console.Write(Words3[i].Replace(_words2[i],"_"));
                        Console.Write("") ;                      i++;
                   }
                   Console.Write($"{Words3[i].SkipLast(1).ToArray()}");
                   Console.Write(Words3[i]);
                
                   i++;
                }
         //          while (Lead != Words.Length)
        //           {
//      //                 Console.WriteLine("Ok");
//      //                 Console.Write(Words2[i]);
        //               Lead++;
        //               i++;

        //           }
                   
                     //  List <string>Words2 =  List<string>();

        //        Console.Write (Words2[i]);            //(Words3.SkipLast(1).ToArray());
        //           i++; 
        //        }
            

//                Console.Write(Words3[i]);
            
//            }
//            Console.WriteLine("Have you grasped it? "  );
//            int j = 0;
//            while (j < Words2.Length)
 //           {
//                Console.Write($"{Words2.SkipLast(1).ToArray()}");
//                Console.Write(j);
//                j++;



//            {            Console.WriteLine(String.Join(",", Words));
            
            }
        }
    }

            



//                Console.Write($"{writeWords2}");
//                Random rdm = new Random();
//                Console.Write(writeWords.Replace("went","_"));
//                Console.Write($"{writeWords2}");
//            }





            
    

        
//        }

//        private class HideWords()
//        {
//            Console.Write($"Words")
////        }



              


//        public static string Instructions()
//        {
//            Console.WriteLine("Please enter your {0} ", );
//            Console.WriteLine("Please enter your {0} ", );
//            Console.WriteLine("Please enter your {0} ", );
//            Console.WriteLine("Please enter your {0} ", );
//            Console.WriteLine("Please enter your {0} ", );
//            return "";
            
//        public static class Join
//        {
//            public void _Verses (int Numbers);
//            {
//                _Verses.Cocat(Verses)
//            } 

//        }

            
            


//        }


        
//        public static class Hide

//        {
//            Book = "";

//            Chapter = "";

//            Verse = ;
//            {
//                start = ;

//                end = ;
//            }




             

//        }



//        static string words()

















//        public string _Book;// =" John";

//        public int _chapter;// =5;

//        public char _colon;

//        public int _Verse;// = 1;



//        public string _writeWords;
//        public Scripture()        {
//            _Book = "John";
//            _chapter =05 ;
//            _Verse = 01 ;
//            _writeWords = "_";  
//        }

//    public class Hider

//    { 
//        public string _Book(string Book)
//        {
 //           return ("John");
//        }
//        public int _chapter(string chapter)
//        {
//            return (5);    
//        }
//        public string Verse(string Verse)
//        {
//            return Verse.Replace("1","_"); 
//        }
//        public void writeWords(string writeWords)
        
        
//        {
//            Console.Write(writeWords.Replace("Jerusalem","_"));
//            List <char> writeWords2 = new List <char>();
            
//            {

//                Console.Write($"{writeWords2}");
//                Random rdm = new Random();
//                Console.Write(writeWords.Replace("went","_"));
//                Console.Write($"{writeWords2}");
//            }
//        }                
//            private void List<T>(object v)
//            {
//                throw new NotImplementedException();
//            }

//        } 
    
//    static void Main(string[] args)
//    {


//        string[] writeWords = { "After ","this ","there ", "was ", "a ","feast ","of ","the ","Jews ","and ","Jesus ","went ","to ","Jerusalem "};

//        Console.WriteLine("Remind your self what John 5:1 says");
//        for (int i = 0; i< writeWords.Length; i++)
//        Console.Write(writeWords[i]);
//        }
//    }     
//}