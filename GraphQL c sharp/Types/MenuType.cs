using GraphQL.Types;
using GraphQL_c_sharp.Models;

namespace GraphQL_c_sharp.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(m=>m.Id);
            Field(m=>m.Name);
            Field(m=>m.Price); 
            Field(m=>m.Description);
        }
    }
}