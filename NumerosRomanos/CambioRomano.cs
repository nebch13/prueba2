using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos
{
   public class CambioRomano
    {

       public String GetRomanStringNumber(int num)
       {
           var solution ="";
           while (num > 0)
           {
               if (num>=10)
               {
                   solution += "X";
                   num -= 10;
               }

           
              else if  (num >= 5)
               {
                   solution += "V";
                   num -= 5;
               }
                   else
	                {
                    if (num ==4)
	                    {
                            solution += "IV";
                            num -= 4;
	                    }
                    else
                    {
                        solution += "I";
                        num--;
                    }
	                }
               
           }
           return solution;
       }

      
       
      
    }
}
