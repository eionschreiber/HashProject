using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashFunk
{
    public class Hash
    {
        public int myHash(string str)
        {

            int res = 0;
            foreach (var c in str)
            {
                int d = c - 'A' + 1;
                res = 26 * res + d;
            }
            return res;
        }
        public void myHashResult()
        { 
            Hash hashCall = new Hash();
            Console.WriteLine("please enter in info");
            string input = Console.ReadLine();
            var ss = new[] { input };
            foreach (var s in ss)
            {
                Console.WriteLine("{0} = {1}", s, hashCall.myHash(s));
            }
        }
    } 
}