using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniAppK205
{
    static class Utilities
    {
        public static bool IsInt(string text)
        {
			try
			{
				Convert.ToUInt32(text);
				return true;
			}
			catch (Exception)
			{

				return false;
			}
        }
    }
}
