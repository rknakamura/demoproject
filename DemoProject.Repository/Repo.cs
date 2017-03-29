using DemoProject.Business.Interface;
using DemoProject.Business.Model;
using System.Linq;

namespace DemoProject.Repository
{
    public class Repo : IRepo
    {
        public HomeModel GetHome()
        {
            using (var context = new ProjetoDemoEntities())
            {
                var table = context.Table.First();

                return new HomeModel
                {
                    Title = table.Title,
                    Button = table.Button
                };
            }
        }
    }
}
