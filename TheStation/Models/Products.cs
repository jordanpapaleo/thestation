using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheStation.Models
{
	public class Products
	{
        public List<Product> GetProducts()
        {
            return this.SalonProducts;
        }

        private List<Product> SalonProducts = new List<Product>
        {
            new Product
            {
                Name = "Morroccan Oil",
                ProductType = ProductTypes.HairCare,
                CompanyUrl = "http://www.moroccanoil.com/",
                LogoUrl = ""
            },
            new Product
            {
                Name = "Bumble & Bumble",
                ProductType = ProductTypes.HairCare,
                CompanyUrl = "http://www.bumbleandbumble.com/",
                LogoUrl = ""
            },
            new Product
            {
                Name = "DEVA Curl",
                ProductType = ProductTypes.HairCare,
                CompanyUrl = "http://www.mydevacurl.com/",
                LogoUrl = ""
            },
            new Product
            {
                Name = "Image Skincare",
                ProductType = ProductTypes.SkinCare,
                CompanyUrl = "http://www.imageskincare.com/",
                LogoUrl = ""
            },
            new Product
            {
                Name = "Schwarzkopf Professional",
                ProductType = ProductTypes.ColorLine,
                CompanyUrl = "http://www.schwarzkopf.com",
                LogoUrl = ""
            }
        };
	}

	public class Product
	{
		public string Name;
		public string LogoUrl;
        public ProductTypes ProductType;
        public string CompanyUrl;
	}

    public enum ProductTypes
    {
        HairCare,
        SkinCare,
        ColorLine
    }
}