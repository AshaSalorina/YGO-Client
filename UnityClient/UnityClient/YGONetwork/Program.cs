using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGONetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            YGOSocketClient client = new YGOSocketClient();
            try
            {
                client.Start();
            }
            finally
            {
                client.Close();
            }
        }
    }
}
