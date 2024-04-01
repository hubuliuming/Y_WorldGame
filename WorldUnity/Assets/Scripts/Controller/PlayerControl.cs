/****************************************************
    文件：PlayerControl.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using System;
using UnityEngine;
using YFramework;

public class PlayerControl : MonoBehaviour,IController
{
    private Rigidbody _rigidbody;
    private GameObject _body;

    private PlayerModel _model;
    
    private Vector3  _movement;
    
    private void Start()
    {
        _body = transform.Find("Body").gameObject;
        _rigidbody = _body.GetComponent<Rigidbody>();

        _model = this.GetModel<PlayerModel>();
    }

    private void Update()
    {
        // 获取玩家的输入  
        float horizontalInput = Input.GetAxis("Horizontal");  
        float verticalInput = Input.GetAxis("Vertical");  
  
        // 计算移动方向  
        _movement = new Vector3(horizontalInput, 0f, verticalInput);
       
       
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * _model.JumpForce);
        }
    }

    private void FixedUpdate()
    {
        // 应用移动  
        Move(_movement);
    }

    void Move(Vector3 movement)  
    {  
        // 将输入转换为移动向量  
        Vector3 move = movement * (_model.MoveSpeed * Time.fixedDeltaTime);  
  
        // 应用移动力到Rigidbody  
        _rigidbody.MovePosition(_rigidbody.position + move);  
    }

    public IArchitecture GetArchitecture()
    {
        return Game.Interface;
    }
}