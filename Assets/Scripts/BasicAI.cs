using UnityEngine;
using System.Collections;

public class BasicAI : MonoBehaviour {
	
	private GameObject player;
	public float enemySpeed = 4.0f;
	// Use this for initialization
	void Start () {
		
		player = GameObject.FindGameObjectWithTag("Player");
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		Vector3 start = transform.position;
		Vector3 end = Vector3.MoveTowards(start, player.rigidbody.position, enemySpeed * Time.deltaTime);
		transform.position = end;
	
	}
}
