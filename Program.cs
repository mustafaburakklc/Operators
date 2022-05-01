using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definition with arithmetic operators
            int x=3;
            
            x+=2; //x=x+2;
            x-=2; //x=x-2;
            x/=2; //x=x/2;
            x*=2; //x=x*2;

            //Logic Operators
            bool yes=true;
            bool no=false;

            if (yes && no)
            {
                Console.WriteLine("yes and no");
            }

            else if (yes || no)
            {
                Console.WriteLine("yes or no");
            }

            else if (!yes && !no)
            {
                Console.WriteLine( "not yes and not no"  );
            }

            else if (!yes || !no)
            {
                Console.WriteLine("not yes or not no");
            }

            //İlişkisel operatörler
            //<,>,<=,>=,==,!=
            int a=3;
            int b=4;
            bool sonuc = a<b; //false
            sonuc= a>b; //true
            sonuc= a<=b; //false
            sonuc= a>=b; //true
            sonuc= a==b; //false
            sonuc= a!=b; //true
        }
    }
}
