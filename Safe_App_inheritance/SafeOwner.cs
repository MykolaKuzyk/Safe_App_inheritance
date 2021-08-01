using System;
using System.Collections.Generic;
using System.Text;

namespace Safe_App_inheritance
{
    class SafeOwner
    {
        private string valuables = "";
        public void ReceiveContents(string safeContents)
        {
            valuables = safeContents;
            Console.WriteLine($"Thank you for returning my {valuables}!");
        }
    }
}
