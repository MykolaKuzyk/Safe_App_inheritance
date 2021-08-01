using System;
using System.Collections.Generic;
using System.Text;

namespace Safe_App_inheritance
{
    class JewelThief: Locksmith
    {
        private string stolenJewels;
        protected void ReturnContents (string safeContets, SafeOwner owner)
        {
            stolenJewels = safeContets;
            Console.WriteLine($"I`m stealing the jewels! I stole: {stolenJewels}");
        }
    }
}
