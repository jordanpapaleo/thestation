using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheStation.Models;

namespace TheStation.ViewModels
{
	public class ImageSorter
	{
		public List<string> FilesToShow = new List<string>();
		public List<string> FilesLeft = new List<string>();
		private List<string> Files = new ImageCollector().FileNames;

		public ImageSorter()
		{
			RandomlySeedList();
		}

		private void RandomlySeedList()
		{
			int numToTake = 1;

			List<string> filesLeft = this.Files;

			Random randomNum = new Random();

			for (int i = 0; i < filesLeft.Count; i++)
			{
				var index = randomNum.Next(0, filesLeft.Count);

				if (i < numToTake)
				{
					this.FilesToShow.Add(filesLeft[index]);

					filesLeft.RemoveAt(index);
				}
				else
				{
					this.FilesLeft = filesLeft;
				}
			}
		}
	}
}