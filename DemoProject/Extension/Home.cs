using DemoProject.Business.Model;
using DemoProject.Models;

namespace DemoProject.Extension
{
    public static class Home
    {
        public static HomeViewModel toView(this HomeModel model)
        {
            return new HomeViewModel
            {
                Title = model.Title,
                Button = model.Button
            };
        }
    }
}