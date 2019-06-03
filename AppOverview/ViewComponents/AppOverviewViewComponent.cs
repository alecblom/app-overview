using AppOverview.Data;
using AppOverview.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppOverview.ViewModels
{
    public class AppOverviewViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(Apps.GetApps().Batch(3));
        }
    }
}