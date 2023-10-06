using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterDetail0202Detail;

namespace MasterDetail0202Detail
{
    internal class MenuItem
    {
        public int Id { get; set; }
        public int Sort { get; set; }
        public string Name { get; set; }
        public string NameVm { get; set; }        
        public string State { get; set; }
        public BaseVM ViewModel { get; set; }

    }
}
