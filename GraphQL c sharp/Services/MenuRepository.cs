using GraphQL_c_sharp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL_c_sharp.Interface;

namespace GraphQL_c_sharp.Services
{

    public class MenuRepository : IMenuRepository
    {
        private static List<Menu> MenuList = new List<Menu>()
        {
            new Menu() {
                Id=1,
                Name="classic Burger",
                Description="A juicy chicken burger with lettuce and cheese",
                Price = 8.99
            },
            new Menu() {
                Id=1,
                Name="classic Burger",
                Description="A juicy chicken burger with lettuce and cheese",
                Price = 9.99
            },
            new Menu() {
                Id=1,
                Name="classic Burger",
                Description="A juicy chicken burger with lettuce and cheese",
                Price = 10.99
            },
            new Menu() {
                Id=1,
                Name="classic Burger",
                Description="A juicy chicken burger with lettuce and cheese",
                Price = 11.99
            },
        };

        public Menu AddMenu(Menu menu)
        {
            MenuList.Add(menu);
            return menu;
        }

        public void DeleteMenu(int id)
        {
            MenuList.RemoveAt(id);
        }

        public List<Menu> GetAllMenus()
        {
            return MenuList;
        }
        public Menu GetMenuById(int id)
        {
            return MenuList.Find(m=>m.Id == id);
        }

        public Menu UpdateMenu(int id, Menu menu)
        {
            MenuList[id] = menu;
            return menu;
        }
    }
}