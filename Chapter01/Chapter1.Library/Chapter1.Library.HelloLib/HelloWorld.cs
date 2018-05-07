using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.Library.HelloLib
{
    public class HelloWorld
    {
        public string SayHello(string name)
        {
            return $"Hello {name}, congratulations !!!, this message is from the class library you created.";
        }
    }
}
