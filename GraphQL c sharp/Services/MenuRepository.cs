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
                Id=2,
                Name="classic Burger",
                Description="A juicy chicken burger with lettuce and cheese",
                Price = 9.99
            },
            new Menu() {
                Id=3,
                Name="classic Burger",
                Description="A juicy chicken burger with lettuce and cheese",
                Price = 10.99
            },
            new Menu() {
                Id=4,
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
            // IDで該当するメニューを検索
            Menu menuToRemove = MenuList.FirstOrDefault(m => m.Id == id);
            
            if (menuToRemove != null)
            {
                // 見つかったメニューを削除
                MenuList.Remove(menuToRemove);
            }
            
            // 指定されたIDのメニューが見つからなかった場合
            // return false;
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
            int index = MenuList.FindIndex(m => m.Id == id);
            
            if (index != -1)
            {
                // 既存のIDを保持することで一貫性を維持
                menu.Id = id;
                
                // 見つかったインデックスのメニューを更新
                MenuList[index] = menu;
                return menu;
            }
            
            // 指定されたIDのメニューが見つからなかった場合
            return menu;
        }
    }
}