using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

class Script
{
    [STAThread]
    static public void Main(string[] args)
    {
        {

			
			  
			  
			   int.TryParse(Console.ReadLine(), out int a);
			   
			   string o;
			   o= Convert.ToString(Console.ReadLine());
			   int.TryParse(Console.ReadLine(), out int b);
			   int result;
					if(o=="+")
				{
					result=a+b;
					Console.WriteLine(result);
				}
					if(o=="-")
				{
					result=a-b;
					Console.WriteLine(result);
				} 
					if(o=="*")
				{
					result=a*b;
					Console.WriteLine(result);
				}
					if(o=="/")
				{
					result=a/b;
					Console.WriteLine(result);
				}
				Console.ReadLine();
			}		
		}
	}
}
