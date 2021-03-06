﻿using UnityEngine;
using System.Collections;

/// <summary>
/// 测试monobehavior
/// </summary>
public class TestMonoBehaviour2 : MonoBehaviour {
    
    void Awake()
    {
        Debug.Log("TestMonoAwake2-" + Time.frameCount);
    }

    /// <summary>
    /// 调用Active = true会立刻跳入到OnEnable逻辑
    /// </summary>
    void OnEnable()
    {
        Debug.Log("TestMonoEnable2-" + Time.frameCount);
    }
    
	/// <summary>
	/// Update第一帧之前
	/// </summary>
	void Start () {
        Debug.Log("TestMonoStart2-" + Time.frameCount);
	}
	
	/// <summary>
	/// 每帧调用
	/// </summary>
	void Update () {
        if(Time.frameCount < 10)
        {
            Debug.Log("TestMonoUpdate2-" + Time.frameCount);
        }
	}

    /// <summary>
    /// 晚于所有Update事件
    /// </summary>
    void LateUpdate()
    {
        if (Time.frameCount < 10)
        {
            Debug.Log("TestMonoLateUpdate2-" + Time.frameCount);
        }
    }
}
