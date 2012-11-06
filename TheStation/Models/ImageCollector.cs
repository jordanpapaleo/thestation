using System.Collections.Generic;
using System.IO;
using System.Web;

namespace TheStation.Models
{
	public class ImageCollector
	{
		private List<string> _FileNames { get; set; }
		
		public List<string> FileNames
		{
			get
			{
				if (null == _FileNames)
				{
					_FileNames = new List<string>();

                    string path = HttpContext.Current.Server.MapPath("~/content/images/stylists");

					var filePaths = Directory.GetFiles(path, "*.jpg");

					foreach (string filePath in filePaths)
					{
						string fileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);
						_FileNames.Add(fileName);
					}
				}

				return _FileNames;
			}
		}
	}
}