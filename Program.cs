using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hello

{
class Program{
  static void Main(string[] args){






 // Type casting
// two types of type casting , implicit casting:- char to int to long to float to double, char to others gives  the  Asci value
 int x = 3;
 float y = x;
 Console.WriteLine(y);



 //explicit casting : When the type casting id manual and is done by the coder
int p  = (int) 3.4;
Console.WriteLine(p);

double n =  3;
Console.WriteLine(n);
 
// casting using the methods.
float var = Convert.ToInt32(3.44);
Console.WriteLine(var);
 














    //if else and data types 
  

  bool isGreat = false;
  Console.WriteLine(isGreat);

  if (isGreat == true){

Console.Write("true");
  }
  else{
    Console.WriteLine("false");
  }








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
