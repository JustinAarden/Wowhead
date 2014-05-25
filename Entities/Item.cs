using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Item : WowObject
    {
        public int Level { get; set; }
        public int ReqLevel { get; set; }
        public string Quality { get; set; }


    }
}
