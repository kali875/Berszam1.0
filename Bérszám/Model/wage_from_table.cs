using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bérszám.Model
{
    internal class wage_from_table
    {
        public wage_from_table(int Wage_ID, string Name) { this.Wage_ID = Wage_ID; this.Name=Name; }
        public int Wage_ID { get; set; }
        public string Name { get; set; }
    }
}
