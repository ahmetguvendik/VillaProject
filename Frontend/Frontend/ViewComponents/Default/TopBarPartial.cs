using System;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.ViewComponents.Default
{
	public class TopBarPartial : ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

