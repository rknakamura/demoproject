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
            return _repo.GetHome();
        }
    }
}