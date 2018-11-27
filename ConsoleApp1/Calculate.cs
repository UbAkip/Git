using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ConsoleApp1Test")]
namespace ConsoleApp1
{
    internal class Calculate
    {
        public int doubleSum(int x)
        {
            return x + x;
        }
        public int minus(int x,int y)
        {
            return x - y;
        }
        public double div(int x, int y)
        {
            return x / y;
        }

        public double averange(double x, double v)
        {
            return(x*v)/2;
        }
    }
}
