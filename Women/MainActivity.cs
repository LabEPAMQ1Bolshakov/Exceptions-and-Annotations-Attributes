using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Women
{
    class MainActivity: Attribute
    {
        private string description;
        
        public MainActivity (string description)
        {
            this.description = description;            
        }

        public string GetDescription()
        {
            return description;
        }
    }
}
