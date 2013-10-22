using UnityEngine;
using System.Collections;

public class Running : MonoBehaviour {
	
	public WalkController walker;
	public float speedWalk = 6.0F;
	public float speedRun = 20.0F;
	public float runStamina = 30.0f;
	private float runCount;
	public bool canRun;

	// Use this for initialization
	void Start () {
		walker.setMoveSpeed(speedWalk);
		runCount = runStamina;
		canRun = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		Debug.Log(runCount);
		
		if (Input.GetKey(KeyCode.Q) && runCount>0 && canRun){
			runCount -= Time.deltaTime;
			if (walker.speed != speedRun){
				walker.setMoveSpeed(speedRun);
				Debug.Log("Aumente Velocidad");
			}
			if(runCount < 0){
				runCount =0;
				canRun = false;
				Debug.Log("no puede correr");
			}
			
		}else{
			if (walker.speed != speedWalk){
				walker.setMoveSpeed(speedWalk);
				Debug.Log("Baje Velocidad");
			}
			if(runCount>runStamina){
				runCount = runStamina;
				canRun = true;
				Debug.Log("Puede Correr");
			}else{runCount += Time.deltaTime*3;}
		}
	
	}
}
