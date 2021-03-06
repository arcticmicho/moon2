﻿using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {
	
	public CharacterController follow;
	public float _parallaxFactor;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
//		Vector3 difference = follow.transform.localPosition - transform.localPosition;
//		difference.z = 0;
//		//Vector3 aux = new Vector3(follow.transform.localPosition.x,0,0);
//		transform.position += (difference * 0.08f * Time.deltaTime);
		Vector3 difference = follow.velocity * _parallaxFactor * Time.deltaTime;
		difference.y = 0f;
		transform.Translate (difference);
	}
}
