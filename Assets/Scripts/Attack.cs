using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	// Use this for initialization
	public float cooldown = 2;
	private float count;
	void Start () {
		count = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyUp(KeyCode.W)){
			if(count == 0){
				//TODO do attack stuffs
				count = cooldown;
			}
		}
		
		if(count > 0){
			count -= Time.deltaTime;	
		}
		if(count < 0){
			count = 0;
		}
	
	}
}
