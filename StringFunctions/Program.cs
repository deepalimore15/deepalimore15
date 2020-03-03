using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {

        public string ReverseString(string valueToReverse)
        {
            string reverseString = string.Empty;
            for (int counter = valueToReverse.Length - 1; counter >= 0; counter--)
            {
                reverseString += valueToReverse[counter];
            }
            return reverseString;
        }


        //String is palindrome or not
        public bool IsPalindromeString(string inputString)
        {
            bool isPalindrome = true;
            int min = 0;
            int max = inputString.Length-1;

            for (int itemcounter = 0; itemcounter < inputString.Length; itemcounter++)
            {
                if (inputString[min] == inputString[max])
                {
                    min++;
                    max--;
                }
                else
                {
                   isPalindrome=false;
                    return isPalindrome;
                }
            }
            return isPalindrome;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter string:-");
        //    var inputString = Console.ReadLine();

        //    //Duplicate Characters in string
        //    if(inputString.Length>0)
        //    {
        //        string result = string.Empty;
        //        string duplicateChar = string.Empty;

        //        foreach (char character in inputString)
        //        {
        //            if (result.ToString().IndexOf(character.ToString().ToLower()) == -1)
        //            {
        //                result += character;
        //            }
        //            else
        //            {
        //                int count = result.ToString().IndexOf(character.ToString().ToLower());
        //                duplicateChar += character;
        //            }

        //        }
        //        Program prgObject = new Program();
        //        var reverseStr = prgObject.ReverseString(inputString);



        //        var wordArray = inputString.Split(' ');
        //        string reversewordArray = string.Empty;
        //        if (wordArray.Length>0)
        //        {

        //            foreach(var item in wordArray)
        //            {
        //                reversewordArray += prgObject.ReverseString(item.ToString());
        //            }
        //        }

        //       for(int icounter=1;icounter<inputString.Length;icounter++)
        //        {
        //            for(int jcounter=0;jcounter<inputString.Length-icounter;jcounter++)
        //            {
        //                var substring = inputString.Substring(jcounter, icounter);
        //                Console.WriteLine("Possible Substring:-{0}", substring);
        //            }
        //        }


        //        string nval=null;                
        //        var test = Convert.ToString(nval);
        //      //  var itemval = nval.ToString();

        //        if (prgObject.IsPalindromeString(inputString))
        //            Console.WriteLine("string is palindrome");
        //        else
        //            Console.WriteLine("string is not palindrome");


        //        //Shift all 1 to right to left and 0 to left in arraylist

        //        int[] numberList = { 0, 1, 1, 0, 0, 1, 1, 1, 1 };


        //        int nCount = 0;
        //        int nEndCount = numberList.Length - 1;


        //        while(nCount<nEndCount)
        //        {

        //            if(numberList[nCount]==1)
        //            {
        //                int temp = numberList[nCount];
        //                numberList[nCount] = numberList[nEndCount];
        //                numberList[nEndCount] = temp;
        //                nEndCount--;  
        //            }
        //            else
        //            {                       
        //                nCount++;
        //            }
        //        }


        //        var intVal = 0;
        //        //Console.WriteLine("duplicate characters:-{0}", duplicateChar);
        //        //Console.WriteLine("remove duplicate characters:-{0}", result);
        //        //Console.WriteLine("String in reverse order:-{0}", reverseStr);
        //        //Console.WriteLine("word in reverse order:-{0}", reverseStr);
        //        //Console.WriteLine("word length:-{0}", wordArray.Length);
        //        Console.ReadLine();
        //    }
        //}


        static void Main()
        {
            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.ReadLine();
        }

        static async void CallMethod()
        {
            string filePath = "D:\\thread.txt";
            Task<int> task = ReadFile(filePath);

            Console.WriteLine(" Other Work 1");
            Console.WriteLine(" Other Work 2");
           

            int length = await task;
             Console.WriteLine(" Other Work 3");
            Console.WriteLine(" Total length: " + length);

            Console.WriteLine(" After work 1");
            Console.WriteLine(" After work 2");
        }

        static async Task<int> ReadFile(string file)
        {
            int length = 0;

            Console.WriteLine(" File reading is stating");
            using (StreamReader reader = new StreamReader(file))
            {
                // Reads all characters from the current position to the end of the stream asynchronously    
                // and returns them as one string.    
                string s = await reader.ReadToEndAsync();

                length = s.Length;
            }
            Console.WriteLine(" File reading is completed");
            return length;
        }
    }
}
