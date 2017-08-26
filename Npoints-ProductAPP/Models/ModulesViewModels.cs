using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Npoints_ProductAPP.Models
{
    public class ModulesViewModels
    {
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        //优先级正序，0最大
        public int ModulePriority { get; set; }
        //是否可见
        public bool ModuleEnable { get; set; } 
    }
}