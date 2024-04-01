/****************************************************
    文件：MapControl.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using System;
using UnityEngine;
using YFramework;

public class MapControl : MonoBehaviour,IController 
{
    private MeshRenderer[]  _meshRenderers;
    private void Start()
    {
        _meshRenderers = GetComponentsInChildren<MeshRenderer>();
        _meshRenderers[0].material.color =Color.yellow;
        _meshRenderers[1].material.color =Color.green;
    }

    public IArchitecture GetArchitecture()
    {
        return Game.Interface;
    }
}