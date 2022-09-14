using System;
using System.Collections.Generic;

namespace BatteryParametersReceiver
{
    public class BatteryDataReceiver
    {        
        public static string DisplayData()
        {        
            Console.WriteLine("Hello");
            string str=Convert.ToString(Console.ReadLine());
            if(str==null)                         
                str="Empty String";
            Console.WriteLine(str);            
            return str;
        }
    }
}
