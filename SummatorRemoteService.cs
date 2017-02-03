using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummatorRemoteService
{
    public class SummatorRemoteService: MarshalByRefObject,ISummatorRemoteService
    {
        public int GetSum(int a, int b)
        {
            return a + b;
        }
    }
}
