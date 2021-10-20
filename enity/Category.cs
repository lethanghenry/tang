using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.enity
{
    class Category
    {
        public int id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = id;
            }
        }
        public string name { get; set; }
        public Category()
        { }
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return "\t" + this.id + "\t" + this.name;
        }
    }
}
