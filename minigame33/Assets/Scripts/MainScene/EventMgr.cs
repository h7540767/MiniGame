﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMgr : MonoBehaviour {
    public static EventMgr _instance;
    public List<EventItem> eventItems;
    public GameObject _camera;

    public Vector3 mainCameraPos;
    public Vector3 eventCameraPos;
	private void OnEnable()
	{
        NotifacitionCenter.getInstance().On("EventHide",Hide);
        NotifacitionCenter.getInstance().On("EventShow", Show);
	}
	private void OnDisable()
	{
        NotifacitionCenter.getInstance().Off("EventHide", Hide);
        NotifacitionCenter.getInstance().Off("EventShow", Show);
	}
	private void Awake()
	{
        _instance = this;
	}
	// Use this for initialization
	void Start () {
        Hide();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Hide(NotifyEvent _event = null)
    {
        for (int i = 0; i < eventItems.Count; i++)
        {
            eventItems[i].gameObject.SetActive(false);
        }
    }

    public void Show(NotifyEvent _event = null)
    {
        for (int i = 0; i < eventItems.Count; i++)
        {
            eventItems[i].gameObject.SetActive(true);
        }
    }
}
