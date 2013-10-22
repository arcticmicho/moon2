using UnityEngine;
using System.Collections;

public class BasicAI : MonoBehaviour {
	
	private GameObject player;
	public float enemySpeed = 4.0f;
	private bool isNear;
	// Use this for initialization
	void Start () {
		
		isNear = false;
		player = GameObject.FindGameObjectWithTag("Player");
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (!isNear) {
			Vector3 start = transform.position;
			Vector3 end = Vector3.MoveTowards(start, player.rigidbody.position, enemySpeed * Time.deltaTime);
			transform.position = end;
			
		}else{
			
		}
	
	}
	
	void OnTriggerEnter(Collider target){
		
		if(target.transform.tag.Equals("Player")){
			isNear = true;	
		}
	}
	
	void OnTriggerExit(Collider target){
		if(target.transform.tag.Equals("Player")){
			isNear = false;	
		}
	}
}
