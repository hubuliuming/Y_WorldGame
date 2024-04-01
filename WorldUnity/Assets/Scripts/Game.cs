/****************************************************
    文件：Game.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Game Entry
*****************************************************/

using YFramework;

public class Game : Architecture<Game>
{
    protected override void Init()
    {
        RegisterModel<PlayerModel>(new PlayerModel());
        RegisterSystem(new TestSystem());
    }
}