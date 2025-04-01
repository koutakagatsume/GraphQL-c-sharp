
using GraphQL.Types;

namespace GraphQL.Type
{
    public class MenuInputType : InputObjectGraphType
    {
        public MenuInputType()
        {
            Name = "MenuInputType";
            // API利用者向けのドキュメント
            Description = "メニュー操作のための入力型";

            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
            Field<FloatGraphType>("price");
        }
    }
}