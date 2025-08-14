using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roblox
{
    public static class Abbreviate
    {
        public static string GetTruncValue(int value)
        {
            if (value < 1000)
                return value.ToString();
            
            if (value < 1000000)
                return (value / 1000).ToString() + "K";
            
            return (value / 1000000).ToString() + "M";
        }
        
        public static string GetTruncValue(long value)
        {
            if (value < 1000)
                return value.ToString();
            
            if (value < 1000000)
                return (value / 1000).ToString() + "K";
            
            return (value / 1000000).ToString() + "M";
        }
    }
}
