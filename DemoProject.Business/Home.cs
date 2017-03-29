using System;
using DemoProject.Business.Interface;
using DemoProject.Business.Model;

namespace DemoProject.Business
{
    public class Home : IHome
    {
        private IRepo _repo;

        public Home(IRepo repo)
        {
            _repo = repo;
        }

        public HomeModel GetHome()
        {
            var model = _repo.GetHome();

            model.Button.ToUpper();
            model.Title.ToUpper();

            return model;
        }
    }
}