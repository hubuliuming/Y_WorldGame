/****************************************************
    文件：TestSystem.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using YFramework;

public class TestSystem : AbstractSystem 
{
    protected override void OnInit()
    {
        this.GetModel<PlayerModel>().MoveSpeed = 3;
        this.GetModel<PlayerModel>().JumpForce = 100;
    }
}