﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventUI : MonoBehaviour {
    public static EventUI _instance;
	private void Awake()
	{
        _instance = this;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnBackClick(){
        UIMgr._instance.PopUI();
    }
}
