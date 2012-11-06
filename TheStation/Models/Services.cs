using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheStation.Models
{
	public class Services
	{
        public Dictionary<string, List<Service>> GetServices()
        {
            var services = new Dictionary<string, List<Service>>();

            services.Add("Hair Care", this.HairServices);
            services.Add("Skin Care", this.SkinServices);
            services.Add("Waxing", this.WaxingServices);

            return services;
        }

		public List<Service> GetHairServices()
		{
			return this.HairServices;
		}

        public List<Service> GetSkinServices()
        {
            return this.SkinServices;
        }

        public List<Service> GetWaxingServices()
        {
            return this.WaxingServices;
        }

        private List<Service> WaxingServices = new List<Service>()
        {
            new Service()
            {
                Name = "Eyebrow",
                Price = "$20"
            },
            new Service()
            {
                Name = "Lip/Chin",
                Price = "$10"
            },
            new Service()
            {
                Name = "Full Face",
                Price = "$30"
            },
            new Service()
            {
                Name = "Bikini",
                Price = "$30 and up"
            },
            new Service()
            {
                Name = "Brazilian",
                Price = "$50 and up"
            },
            new Service()
            {
                Name = "Nose",
                Price = "$10 and up"
            },
            new Service()
            {
                Name = "Half Arm",
                Price = "$20 and up"
            },
            new Service()
            {
                Name = "Full Arm",
                Price = "$35 and up"
            },
            new Service()
            {
                Name = "Under Arm",
                Price = "$20 and up"
            },
            new Service()
            {
                Name = "Half Leg",
                Price = "$30 and up"
            },
            new Service()
            {
                Name = "Full Leg",
                Price = "$50 and up"
            },
            new Service()
            {
                Name = "Back/Chest",
                Price = "$25 and up"
            },
        };

        private List<Service> SkinServices = new List<Service>()
        {
            new Service()
            {
                Name = "Custom Facial",
                Price = "$75 and up"
            },
            new Service()
            {
                Name = "Microdermabrasion",
                Price = "$65 and up"
            },
            new Service()
            {
                Name = "Chemical Peeling",
                Price = "$65 and up"
            },
            new Service()
            {
                Name = "Dermaplaning",
                Price = "$65 and up"
            },
            new Service()
            {
                Name = "4 Treatment Package",
                Price = "$250"
            },
            new Service()
            {
                Name = "6 Treatment Package",
                Price = "$350"
            },
            new Service()
            {
                Name = "Eyelash Extensions Full Set",
                Price = "$225 and up"
            },
            new Service()
            {
                Name = "Eyelash Extension Fill",
                Price = "$20 per 15 minites"
            },
            new Service()
            {
                Name = "Eyebrow Tinting",
                Price = "$10"
            },
            new Service()
            {
                Name = "Eyelash Tinting",
                Price = "$20"
            }

        };

		private List<Service> HairServices = new List<Service>()
		{
			new Service()
			{
				Name = "Men's Haircut",
				Price = "$30"
			},
			new Service()
			{
				Name = "Men's Curly Haircut",
				Price = "$35"
			},
			new Service()
			{
				Name = "Women's Haircut",
				Price = "$50"
			},
			new Service()
			{
				Name = "Women's Curly Haircut",
				Price = "$72"
			},
			new Service()
			{
				Name = "Color Retouch",
				Price = "$85 and up"
			},
			new Service()
			{
				Name = "Highlights",
				Price = "$95 and up"
			},
			new Service()
			{
				Name = "Full color",
				Price = "$100 and up"
			},
			new Service()
			{
				Name = "Style/Curly Set",
				Price = "$35 and up"
			},
			new Service()
			{
				Name = "Up-Do",
				Price = "$65 and up",
				Notes = "Ask about the great Bridal and Bachelorette Packages we offer"
			},
			new Service()
			{
				Name = "Brazilian Straighteners",
				Price = "$150 and up"
			},
			new Service()
			{
				Name = "Japanese Straighteners",
				Price = "Price upon consultation"
			},
			new Service()
			{
				Name = "Perm",
				Price = "Price upon consultation"
			},
			new Service()
			{
				Name = "Extensions",
				Price = "Price upon consultation",
                Notes = "BABE, Easi Hair, Simplicity "
			}
		};
	}

	public class Service
	{
		public string Name;
		public string Price;
		public string Notes;
        public ServiceType Type;
	}

    public enum ServiceType
    {
        Hair,
        Skin
    }
}