using System;
using System.Collections.Generic;
namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
           var userresp = new HashSet<string>{"YES","Y","NO","N"};
           string answer = default ;
            
            do{
                int choice;
                Console.WriteLine("Enter your Choice :1. Height from metres to feet and inches 2. Height from feet to metres 3. Kg to Lb 4.Lbs to Kg 5.Convert Celsius to Fahrenheit 6.Convert Fahrenheit to celsius.");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
        
                case 1:
                    double height_In_Ft, height_In_metres, inches, ft_in_mt = 0.3048;
                    int ft;
                    string input;
    
                    Console.WriteLine("please enter height in metres");
                    input = Console.ReadLine();
                    height_In_metres = double.Parse(input);

                    height_In_Ft = height_In_metres / ft_in_mt;
                    ft = (int)height_In_Ft;
                    inches = height_In_metres / ft_in_mt % 1 *12;
    
                    Console.WriteLine("{0} feet {1} inches.", ft, inches);
                    break;
                case 2:
                    double meter, feet, mt_to_ft = 3.28084 ;
                    Console.WriteLine("Enter feet :");
                    feet = Convert.ToInt32(Console.ReadLine());
                    meter = feet / mt_to_ft;
                    Console.WriteLine("\nFeet in meter : " + meter);          
                
                    break;
                case 3:
                    Console.WriteLine("KG to LB program\n");
                    Console.Write("Enter a number in KG: ");

                    double kilograms = Convert.ToDouble(Console.ReadLine());
                    double Lb = kilograms * 0.45359237;
                    Console.WriteLine(kilograms + " kilograms is " + Lb + " Lbs");
                    break;
                case 4:
                    Console.WriteLine("lb to kg program\n");
                    Console.Write("Enter a number in LB: ");
                    double weight_In_LB = Convert.ToDouble(Console.ReadLine());
                    double weight_In_KG = weight_In_LB /2.2046;
                    Console.WriteLine(weight_In_LB + " LB is " + weight_In_KG + " Kg");
                    break;
            
                case 5: 
                    double fahrenheit;
                    double celsius;
                    Console.WriteLine("enter temperature in celsius");
                    celsius=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Celsius: " + celsius);
                    fahrenheit = (celsius * 2) + 32;
                    Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
                    break;
                
                case 6: 
                    double temp_IN_fahrenheit;
                    double temp_IN_celsius;
                    Console.WriteLine("enter temperature in fahrenheit");
                    temp_IN_fahrenheit =Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Temperature in fahrenheit: " + temp_IN_fahrenheit);
                    temp_IN_celsius = (temp_IN_fahrenheit - 32) / 1.8000;
                    Console.WriteLine("celsius : " + temp_IN_celsius);
                    break;
                    Console.WriteLine("enter Y to continue or n to exit");
                    answer = Console.ReadLine();
                }
            }while(userresp.Contains(answer));
        }
    }
}