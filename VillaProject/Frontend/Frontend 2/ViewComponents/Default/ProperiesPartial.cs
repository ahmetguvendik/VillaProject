using System;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.ViewComponents.Default
{
	public class ProperiesPartial : ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

