using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Npoints_ProductAPP.Models
{
    public class HomePageViewModels
    {
        public LinkedList<ModulesViewModels> modules { get; set; }

        public LinkedList<ProductViewModels> products { get; set; }
    }
}