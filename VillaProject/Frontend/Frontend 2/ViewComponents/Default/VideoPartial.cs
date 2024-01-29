using System;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.ViewComponents.Default
{
	public class VideoPartial : ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

