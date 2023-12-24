using System;
namespace ConvSumToUS
{
    class Program{
        static void Main(string[] args){


           bool isCorrect = false;
           int number = 0;
           while(!isCorrect){
             Console.WriteLine("******* Convertatsiya ********");
             Console.Write("1.UZS to USD \n2.USD to UZS\n");
             Console.Write("choose the options: ");
             number = Convert.ToInt32(Console.ReadLine());
             isCorrect=false;


                double UZS,USD;
           if (number == 1)
             {
               System.Console.Write("Enter UZS amount: ");
               UZS = double.Parse(Console.ReadLine());
               USD =  UZS / 12369.84;
               System.Console.WriteLine(USD);
             }
             
             else if(number==2){
                 System.Console.Write("Enter USD amount: ");
               USD = double.Parse(Console.ReadLine());
               UZS =  USD * 12369.84;
               System.Console.WriteLine(UZS);
             }
             else
             {
                System.Console.WriteLine("invalid number!!!");
             }
           }

        
             
 
             
        }
    }
}
