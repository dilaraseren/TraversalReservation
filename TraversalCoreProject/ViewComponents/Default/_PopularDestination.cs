using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _PopularDestination:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
