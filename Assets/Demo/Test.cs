
#region 版权信息
/*
 * -----------------------------------------------------------
 *  Copyright (c) KeJun All rights reserved.
 * -----------------------------------------------------------
 *		描述: 
 *      创建者：#DEVELOPERNAME#
 *      创建时间: #CREATIONDATE#
 *  
 */
#endregion


using Microsoft.Win32;
using UnityEngine;

public class Test : MonoBehaviour
{
    #region Fields

    #endregion

    #region Properties

    #endregion

    #region Unity Messages
    //    void Awake()
    //    {
    //
    //    }
    //    void OnEnable()
    //    {
    //
    //    }
    //
    void Start()
    {
        string[] subkeyNames;

        RegistryKey hkml = Registry.LocalMachine;

        RegistryKey software = hkml.OpenSubKey("SOFTWARE");

        subkeyNames = software.GetSubKeyNames();

        //取得该项下所有子项的名称的序列，并传递给预定的数组中

        foreach (string keyName in subkeyNames)  //遍历整个数组
        {
            Debug.LogError(keyName);
        }

        hkml.Close();
    }
    //    
    //    void Update() 
    //    {
    //    
    //    }
    //
    //    void OnDisable()
    //    {
    //
    //    }
    //
    //    void OnDestroy()
    //    {
    //
    //    }

    #endregion

    #region Private Methods

    #endregion

    #region Protected & Public Methods

    #endregion
}