using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class Permutations
    {
        public List<string> Run(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length == 1)
                return new List<string> { value };
            return null;
        }

    }
}
