using System;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.ViewComponents.Default
{
	public class SliderPartial :  ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

