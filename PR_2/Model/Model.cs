using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_2.Model
{
    internal class zametka
    {
        public zametka(string name, string description, DateTime date)
        {
            Name = name;
            Description = description;
            this.date = date;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime date { get; set; }
    }
}
