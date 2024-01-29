using System;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.ViewComponents.Default
{
    public class VillaDetailPartial : ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

