using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Npoints_ProductAPP.Models;

namespace Npoints_ProductAPP.Controllers
{
    public class ProductsController : ApiController
    {
        ProductViewModels[] products = new ProductViewModels[]
       {
            new ProductViewModels{ PID = "OK2017826q",PName="商品一",POriginPrice=420.0f,PDiscount=30.0f,PImageUrl="~/img/path/image1.jpg",PDetials="我是一大串描述1",PCategory="分类一"},
            new ProductViewModels{ PID = "OK2017826q",PName="商品二",POriginPrice=410.0f,PDiscount=37.0f,PImageUrl="~/img/path/image2.jpg",PDetials="我是一大串描述2",PCategory="分类二"},
            new ProductViewModels{ PID = "OK20382a6q",PName="商品三",POriginPrice=411.0f,PDiscount=41.0f,PImageUrl="~/img/path/image3.jpg",PDetials="我是一大串描述3",PCategory="分类三"},
            new ProductViewModels{ PID = "OK2317326q",PName="商品四",POriginPrice=125.0f,PDiscount=41.0f,PImageUrl="~/img/path/image1.jpg",PDetials="我是一大串描述1",PCategory="分类一"},
            new ProductViewModels{ PID = "OK2013282q",PName="商品五",POriginPrice=185.0f,PDiscount=47.0f,PImageUrl="~/img/path/image2.jpg",PDetials="我是一大串描述2",PCategory="分类二"},
            new ProductViewModels{ PID = "OK2017823q",PName="商品六",POriginPrice=180.0f,PDiscount=40.0f,PImageUrl="~/img/path/image3.jpg",PDetials="我是一大串描述3",PCategory="分类三"}
       };
        //提供给首页
        public IEnumerable<ProductViewModels> GetAllProducts()
        {
            foreach (ProductViewModels p in products)
            {
                //排除掉不可以显示的商品
                if(p.PIsPublish == 0)
                {
                    
                }
                //排除掉不在首页显示的商品
                if (p.PHomeDisplay == 0)
                {

                }

            }
            return products;
        }
        //提供给分类页
        public IEnumerable<ProductViewModels> GetAllProductsforCategory()
        {
            foreach (ProductViewModels p in products)
            {
                //排除掉不可以显示的商品
                if (p.PIsPublish == 0)
                {

                }

            }
            return products;
        }
        //通过ID返回商品
        public IHttpActionResult GetProduct(string PID)
        {
            var product = products[0];
            foreach (ProductViewModels p in products)
            {
                if (p.PID.Equals(PID))
                {
                    product = p;
                }
            }
            if (null == product)
            {
                return NotFound();
            }
            return Ok(product);
        }

        //是否展示
        public int IsPublish()
        {
            return 0;
        }

        //是否在首页展示
        public int HomeDisplay()
        {
            return 0;
        }
     
        //是否是特殊商品
        public int isFeaturesProduct()
        {
            return 0;
        }
    }
}
