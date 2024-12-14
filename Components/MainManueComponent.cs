using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Components
{
    public class MainManueComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
