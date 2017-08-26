using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Npoints_ProductAPP.Models
{
    public class ProductViewModels
    {
        //商品编号
        public string PID { get; set; }
        //商品名称
        public string PName { get; set; }
        //商品的原始价格
        public float POriginPrice { get; set; }
        //商品的折扣价
        public float PDiscount { get; set; }
        //商品图片路径
        public string PImageUrl { get; set; }
        //商品详细介绍
        public string PDetials { get; set; }
        //商品简短介绍
        public string PBriefExplanation { get; set; }
        //获取分类信息
        public string PCategory { get; set; }
        //商品库存量
        public int PStock { get; set; }
        //是否是特殊商品
        public int PFeaturesProduct { get; set; }
        //是否禁止购买
        public int PForbidBuy { get; set; }
        //是否显示
        public int PIsPublish { get; set; }
        //获取优先级
        public int PPriority { get; set; }
        //商品可以购买的最大数量
        public int PMaxNumber { get; set; }
        //是否在首页展示
        public int PHomeDisplay { get; set; }
        //展示在某模块中
        public int PMoudels { get; set; }
        //商品创建时间
        public int PIndate { get; set; }
        //商品售卖的开始时间
        public int PStartTime { get; set; }

      
    }
  
}