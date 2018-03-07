﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceMessageBoard : MonoBehaviour {
	
	public Collider2D message;
	public FenceCollider fence;

	// Use this for initialization
	void Start () {
	    message = GetComponent<Collider2D>();
	    fence = GetComponent<FenceCollider>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (fence.fenceCount == 5)
	    {
	         message.isTrigger = false;  
	    }
	}
}
