using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Npoints_ProductAPP.Models;

namespace Npoints_ProductAPP.Controllers
{
    public class BannerController : ApiController
    {
        BannerViewModels[] banner = new BannerViewModels[]
        {
            new BannerViewModels{BannerID=10232,BannerLink="banner的链接一",BannerImageUrl="banner的图片" },
            new BannerViewModels{BannerID=45232,BannerLink="banner的链接二",BannerImageUrl="banner的图片" },
            new BannerViewModels{BannerID=10432,BannerLink="banner的链接",BannerImageUrl="banner的图片三" },
            new BannerViewModels{BannerID=18612,BannerLink="banner的链接",BannerImageUrl="banner的图片四" }
        };

        public IEnumerable<BannerViewModels> GetAllBanners()
        {
            return banner;
        }
        
    }
}
