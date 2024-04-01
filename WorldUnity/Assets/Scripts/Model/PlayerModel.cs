/****************************************************
    文件：PlayerModel.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using UnityEngine;
using YFramework;

public class PlayerModel : AbstractModel
{
    private float _moveSpeed;

    public float MoveSpeed
    {
        get => _moveSpeed;
        set => _moveSpeed = value;
    }
    private float _jumpForce;

    public float JumpForce
    {
        get => _jumpForce;
        set => _jumpForce = value;
    }
    
    
    protected override void OnInit()
    {
        
    }
}