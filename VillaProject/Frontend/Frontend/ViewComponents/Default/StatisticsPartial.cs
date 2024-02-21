using System;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.ViewComponents.Default
{
	public class StatisticsPartial : ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

