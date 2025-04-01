using GraphQL_c_sharp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL_c_sharp.Interface;
using GraphQL_c_sharp.Data;

namespace GraphQL_c_sharp.Services
{

    public class MenuRepository : IMenuRepository
    {
        private GraphQLDbContext dbContext;
        public MenuRepository(GraphQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Menu AddMenu(Menu menu)
        {
            dbContext.Menus.Add(menu);
            dbContext.SaveChanges();
            return menu;
        }

        public void DeleteMenu(int id)
        {
            var menuResult = dbContext.Menus.Find(id);
            dbContext.Menus.Remove(menuResult);
            dbContext.SaveChanges();
        }

        public List<Menu> GetAllMenus()
        {
            return dbContext.Menus.ToList();
        }
        public Menu GetMenuById(int id)
        {
            return dbContext.Menus.Find(id);
        }

        public Menu UpdateMenu(int id, Menu menu)
        {
            var menuResult = dbContext.Menus.Find(id);
            menuResult.Name = menu.Name;
            menuResult.Description = menu.Description;
            menuResult.Price = menu.Price;

            dbContext.SaveChanges();
            return menu;
        }
    }
}