using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.Core.Extensions
{
    public static class ValidableExtensions
    {
        public static bool IsValid(this IValidable obj)
        {
            try
            {
                obj.Validate();
                return true;
            }
            catch { return false; }
        }
    }
}
