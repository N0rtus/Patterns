using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class LightTheme : ITheme
    {
        public string SetColor()
        {
            return "light theme";
        }
    }
}
