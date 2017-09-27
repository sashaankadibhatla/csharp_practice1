using System;
using palindrome_program;
using program2;
using program3;
using program4;
using program5;
using program6;
namespace practice_code
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1.Program1\n2.Program2\n3.Program3\n4.Program4\n5.Program5\n6.Program6\n7.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1: Console.WriteLine("Enter the number sequence");
                            string sequence=Console.ReadLine();
                            palindrome ob1=new palindrome();
                            ob1.palindrome_fun(sequence);
                            break;
                    case 2: Console.WriteLine("Enter a number");
                            int number=int.Parse(Console.ReadLine());
                            Tom_Jerry ob2=new Tom_Jerry();
                            ob2.Tom_Jerry_fun(number);
                            break;
                    case 3: Console.WriteLine("Enter a word string");
                            string sequence1=Console.ReadLine();
                            vowel_consonant ob3=new vowel_consonant();
                            ob3.vowel_consonant_fun(sequence1);
                            break;
                    case 4: Console.WriteLine("enter a number to loop the series");
                            int number1=int.Parse(Console.ReadLine());
                            loop ob4= new loop();
                            ob4.loop_fun(number1);
                            break;
                    case 5: Console.WriteLine("enter the number");
                            string sequence2=Console.ReadLine();
                            sort_number ob5=new sort_number();
                            ob5.sort_number_fun(sequence2);
                            break;
                    case 6: Console.WriteLine("enter a string");
                            string sequence3=Console.ReadLine();
                            Console.WriteLine("enter a number");
                            int number2=int.Parse(Console.ReadLine());
                            repeatpart ob6=new repeatpart();
                            ob6.repeatpart_fun(sequence3,number2);
                            break;
                    case 7:Environment.Exit(0);
                           break;
                    default: Console.WriteLine("Entered wrong option, please choose rigth choice");
                             break;
                }
            }
        }
    }
}
