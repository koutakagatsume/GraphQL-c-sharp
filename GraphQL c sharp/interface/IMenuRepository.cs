using GraphQL_c_sharp.Models;

namespace GraphQL_c_sharp.Interface
{
    public interface IMenuRepository
    {
        List<Menu> GetAllMenus();
        Menu GetMenuById(int id);
        Menu AddMenu(Menu menu);
        Menu UpdateMenu(int id, Menu menu);
        void DeleteMenu(int id);
        
        // ---
        // Task<IEnumerable<Menu>> GetAllMenusAsync();
        // Task<Menu> GetMenuByIdAsync(int id);
        // Task<Menu> AddMenuAsync(Menu menu);
        // Task<Menu> UpdateMenuAsync(Menu menu);
        // Task<bool> DeleteMenuAsync(int id);
    }
}