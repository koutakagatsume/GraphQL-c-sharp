using GraphQL_c_sharp.Type;
using GraphQL.Types;
using GraphQL_c_sharp.Interface;
using GraphQL;
using GraphQL.Type;
using GraphQL_c_sharp.Models;

namespace GraphQL_c_sharp.Mutation
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenuRepository menuRepository)
        {
            Field<MenuType>("createMenu").Arguments(new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" })).Resolve(context =>
            {
                return menuRepository.AddMenu(context.GetArgument<Menu>("menu"));
            });

            Field<MenuType>("UpdateMenu").Arguments(new QueryArguments(
                new QueryArgument<IntGraphType> { Name = "menuId" },
                new QueryArgument<MenuInputType> { Name = "menu" }
                )).Resolve(context =>
            {
                var menu = context.GetArgument<Menu>("menu");
                var menuId = context.GetArgument<int>("menuId");
                return menuRepository.UpdateMenu(menuId, menu);
            });

            Field<StringGraphType>("DeleteMenu").Arguments(new QueryArguments(
                new QueryArgument<IntGraphType> { Name = "menuId" },
                new QueryArgument<MenuInputType> { Name = "menu" }
                )).Resolve(context =>
            {
                var menuId = context.GetArgument<int>("menuId");
                menuRepository.DeleteMenu(menuId);
                return "The menu against this Id" + menuId + "has been deleted";
            });
        }
    }
}