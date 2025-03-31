using GraphQL_c_sharp.Query;

namespace GraphQL_c_sharp.Schema
{
    public class MenuSchema : GraphQL.Types.Schema
    {
        public MenuSchema(MenuQuery menuQuery)
        {
            Query = menuQuery;

        }
    }
}