﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class EventItem : MonoBehaviour {
    public Vector3 startPos;
    public Vector3 endPos;
	// Use this for initialization
	void Start () {
        startPos = transform.localPosition;
        endPos = startPos + new Vector3(0, 0.5f, 0);
        transform.DOLocalMove(endPos, 0.5f).SetLoops(-1,LoopType.Yoyo);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

	private void OnMouseDown()
    {
        EventMgr._instance._camera.GetComponent<CameraGy>().enabled = false;
        EventMgr._instance._camera.transform.position = EventMgr._instance.eventCameraPos;
        UIMgr._instance.PushUI(UIMgr._instance.eventUI);
	}
}
