using Microsoft.AspNetCore.Mvc;
using OdeToFood.Services;
using OdeToFood.ViewModels;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            HomePageViewModel viewModel = new HomePageViewModel();
            viewModel.Restaurants = _restaurantData.GetAll();
            viewModel.CurrentMessage = _greeter.GetGreeting();
             
            return View(viewModel);
        }
    }
}
