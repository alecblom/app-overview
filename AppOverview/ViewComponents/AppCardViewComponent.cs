using AppOverview.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppOverview.ViewModels
{
    public class AppCardViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(AppModel app)
        {
            return View(app);
        }
    }
}