using System;

namespace Applied_tasks
{
    class Program
    {
        static void Main(string[] args)
        {   
            decimal cost = decimal.Parse(Console.ReadLine());
            Console.WriteLine(cost * 0.8m);
            Console.WriteLine(cost * 0.2m);
            Console.WriteLine(MathRound(cost, 0.8m));
            Console.WriteLine(MathRound(cost , 0.2m));
            

        }

        public static int MathRound(decimal number, decimal rate)
        {
            int res = Convert.ToInt32(number * rate);
            if ((((number*rate-res))*10) % 5 == 0 && number * rate - res!=0)
            {
                return (Convert.ToInt32(number * rate)+1);
            }
            else
            {   
                return (Convert.ToInt32((number * rate) ));
            }
        }





        

        }
       
        
        

        }
    
    

