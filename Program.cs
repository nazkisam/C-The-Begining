using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hello

{
class Program{
  static void Main(string[] args){


    int harry  = 30;  //int takes 4 bytes
    string inp = Console.ReadLine() ?? string.Empty; //char takes 2 bytes bool takes one bit, long takes 8 bytes,doule takes 8 bytes upt to 15  decimal digits precision 
    Console.WriteLine(inp);


    float i = 32.1F;
    double d = 32.9;
    Console.WriteLine(i+d);






    Console.WriteLine("hello"); //write line goes to new line and write writes over the same line. 
    Console.ReadLine();
    Console.WriteLine("this is the number" + harry);
  }
}


}
