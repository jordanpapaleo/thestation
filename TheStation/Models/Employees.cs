using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheStation.Models
{
	public class Employees
	{
		public List<Employee> GetStaff()
		{
            return this.Staff;
		}

		private List<Employee> Staff = new List<Employee>()
		{
			new Employee()
			{
				ID = 7,
				Name = "Micki Lighthill",
				Profession = ProfessionType.Stylist,
                ImgName = "micki.jpg",
				Bio = new List<string>()
				{
					"A self-proclaimed hair architect, Micki has been transforming hair and making her clients beautiful since 2002.    Her expertise includes cutting hair for men, women and children.  Considered a hair color expert by her clients and colleagues, Micki has a refreshing and upbeat approach to highlights, color and cuts.  She is also a curly hair expert and can help tame your curls so you can fall in love with your hair again.",
                    "Micki has trained exclusively from schools of Bumble & Bumble, Deva Curl, Schwartzkopf, American Crew, Vidal Sasson, Toni & Guy and Wella.   She also attends ongoing advanced training and education for cutting, color and styling to stay current and deliver the latest trends and techniques to her clients.",
                    "On her days off, Micki enjoys spending time outdoors with her family, taking hikes, going for runs and cooking meals at home.  New clients are always welcome!"
				}
			},
			new Employee()
			{
				ID = 6,
				Name = "Christy Austin",
				Profession = ProfessionType.Esthetician,
                ImgName = "christy.jpg",
				Bio = new List<string>()
				{
					"Christy Austin is an esthetician with seven years experience.  Being that she was raised in Colorado, Christy understands “Colorado Skin”.  Whether you are a Colorado native or not Christy has a great deal of experience balancing the effects that this beautiful Colorado environment has on your skin.  Not only can she address all of your skin care and hair removal concerns, but she can also educate you on how to best care for your own skin for maximum results and effectiveness.",
					"Christy is married with two children and two cats.  She enjoys spending time outdoors, shopping with her daughter, and playing “Transformers” with her son.  She also is a big fan of live music."
				}
			},
			new Employee()
			{
				ID = 5,
				Name = "Dayna Geiger",
				Profession = ProfessionType.Esthetician,
                ImgName = "dayna.jpg",
				Bio = new List<string>()
				{
					"Dayna Geiger has been an esthetician since early 2007. Working in this field is a perfect blend of both the artsy and scientific parts of Dayna's brain. What she most enjoys about her job is getting to know her clients and customizing each person's experience. She loves being that one magic person you found who does the job just right.",
					"Dayna studied skin care at the College of International Esthetics, where she also gained certifications in Microdermabrasion and Chemical Peeling. She has also received advanced education in various skin treatments with Image Skin Care, as well as other product lines. She has a certification in eyelash extensions from Lavish Lashes, as well as advanced training in that aspect of her practice.",
					"Eyelash extensions are one of Dayna's specialties and most popular service. Her attention to detail and odd affinity toward tedious and difficult tasks make augmenting this facial feature a perfect treatment for Dayna to provide. These personality traits also make her especially good at brow shaping, another favorite service of Dayna's.",
					"When not working in her treatment room, Dayna is a wife, mother, singer, songwriter, and rock star. You might see her on various Denver stages with her band, Starcar Sunday."
				}
			},
			new Employee()
			{
				ID = 4,
				Name = "Jeanna Ouellette" ,
				Profession = ProfessionType.Stylist,
                ImgName = "jeanna.jpg",
				Bio = new List<string>()
				{
					"Jeanna Ouellette grew up in Castle Rock, Colorado. She is proud to call Denver her home, but enjoys traveling as much as possible. The ability to do that in her field of work made hair styling an easy career choice.",
					"Jeanna began her career in early 2008, studying at the Aveda Institute of Denver. She began specializing in naturally curly hair in early 2009, training with Deva Curl in New York, as well as extensive classes here in Denver. She has since branched out with other lines such as Moroccan Oil, expanding her curl knowledge. Jeanna has extensive training with Schwarzkopf color, having had hands-on education with many of the Schwarzkopf educators. Her professional drive has led her to study with cutting specialist Kathy Simon, color specialist Misael Aponte, and other companies such as Global Keratin, Lazio, and Surface.",
					"Hair is her passion, and Jeanna takes pride in making sure each unique person in her chair can be given the look they desire."
				}
			},
			new Employee()
			{
				ID = 3,
				Name = "Mary Veraldo",
				Profession = ProfessionType.Stylist,
                ImgName = "mary.jpg",
				Bio = new List<string>()
				{
					"Mary Veraldo has been in the beauty industry since 2002. Practicing on Barbie’s and My Little Ponies as a child, Mary always knew she wanted to be a hairstylist.  She loves getting to know people and helping them look and feel their best",
					"Mary has traveled across the county from New York to L.A. for continued education. She has studied with Bumble and Bumble, Deva Curl, Schwarzkopf, Wella, Moroccan Oil, Babe hair extensions, and Glo Minerals. She has also had extensive training locally. Mary’s specialties include color from punk rock to sun-kissed tones, Japanese Straightening, Razor cutting, and Bridal Updos and Makeup. Mary has done hair and makeup for numerous fashion shows and photo shoots around Denver.",
					"Outside of the salon Mary enjoys painting, spending time with her fur-children, long walks, shoe shopping, random road trips, and dance parties in her kitchen."
				}
			},
			new Employee()
			{
				ID = 2,
				Name = "Megan Moden",
				Profession = ProfessionType.Stylist,
                ImgName = "megan.jpg",
				Bio = new List<string>()
				{
					"Megan Moden has been in the beauty and fashion industry since 2004.  She loves making people look and feel their best by using her imagination to create new and exciting looks that are customized for each client.",
					"She studied cosmetology at Pickens Technical School, and has numerous certifications with Deva Curl, Crew, Redken,  Schwarzkopf , Easihair, and Babe hair extensions.  She also studied the Mecca cutting method with Kathy Simon.",
					"Megan specializes in color and curly hair. She has studied in depth with Schwarzkopf Professional Color, and Deva Curl. Megan can work her magic on any color, ranging from bold to beautifully blended blonds. She can tame even the wildest of curly hair, and loves a good A-Line bob. Megan is also very talented with updos and styling. She will make you look fabulous for any special occasion.",
					"Megan is married and has a beautiful son who was born in 2010. She loves fishing, swimming, and being outdoors.  Anytime she can be out in the sunshine, she’s there. Megan has a great sense of humor and can be quite a goofball. If you love to laugh then she’s your girl!"
				}
			},
			new Employee()
			{
				ID = 1,
				Name = "Jamie Stewart",
                ImgName = "jamie.jpg",
				Profession = ProfessionType.Stylist,
                ExperienceStart = new DateTime(2005, 5, 1),
                Experience = (DateTime.Now - new DateTime(2005, 5, 1)).ToString(),
				Bio = new List<string>()
				{
					"Jamie is a Colorado native who brings seven years of experience to our salon. She loves helping curly girls by teaching them how to bring out the best in their hair and master their curls. She is a Deva Curl Architect who has gone though intensive training both in New York and Denver with the Deva program.",
					"Jamie is educated in the Schwarzkopf color line, and loves creating anything from dimensional yet natural looks to bold and beautiful. She has completed training in California for Easi Hair extensions, amongst other hair extension companies, and has the ability to create beautiful length and volume to pre-existing hair.  She also has an eye for wedding hair, as well as up-dos for other special occasions. Jamie has trained with well-known color artist Misael Aponte, and cutting technician Kathy Simon.",
					"Jamie’s genuine passion is making clients feel beautiful and realize the true potential of their hair. She is very detailed oriented and meticulous in her work and will take the time necessary to give you the cut and color that best suits you. Jamie loves spending time with her big family and takes pride in making each of her clients feel like a part of it."
				}
			},
            new Employee()
            {
                ID = 8,
                Name = "Julia McBride",
                Profession = ProfessionType.Stylist,
                Link = "http://www.denverpost.com/lifestyles/ci_17559001",
                ImgName = "julia.jpg",
                LinkLabel = "Julia is featured in this article",
                Bio = new List<string>()
                {
                    "Julia McBride is one of the first stylists in Colorado to have trained at Devachan in New York City and specializes in curly hair. She is a local educator for Deva Curl and recently became a Curl Architect, completing their 3 day class in Manhattan. She is a creative and attentive hairstylist known to create beautiful Schwarzkopf color, and prides herself in staying up-to-date on the most current cuts and styles through continuing education in the industry. She loves the daily opportunity to make people look and feel their best. Julia has been licensed in the industry since 2001 but started her hairstyling career many years before styling hair for many local theatre productions. In her spare time, Julia loves to do 50's inspired hairstyles, enjoys theatre, art, and jogging with her two dogs in Wash Park."
                }
            }
		};
	}

	public class Employee
	{
		public int ID;
		public string Name;
		public ProfessionType Profession;
        public string ImgName;
		public List<string> Bio;
        public string Link;
        public string LinkLabel;
        public DateTime ExperienceStart;
        public string Experience;// = this.Ex
	}

	public enum ProfessionType
	{
		Stylist,
		Esthetician,
		Manager
	}
}