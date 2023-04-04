using AboutCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AboutCard_MVC.ViewComponents
{
	public class BestProjectViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var project = new List<BestProject>()
			{
				new BestProject()
				{
					Id = 1,
					Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.",
					Title = "آموزش جاوا اسکریپت",
					Image = "blog-post-thumb-card-1.jpg"
				},
				new BestProject()
				{
					Id = 2,
					Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.",
					Title = "آموزش پایتون",
					Image = "blog-post-thumb-card-2.jpg"
				},
				new BestProject()
				{
					Id = 3,
					Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.",
					Title = "آموزش سی شارپ",
					Image = "blog-post-thumb-card-3.jpg"
				}

			};
			return View("_bestproject",project);
		}
	}
}
