using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

	tk2dCamera cam;
	public Transform target;
	public float followSpeed = 1.0f;

	public float minZoomSpeed = 20.0f;
	public float maxZoomSpeed = 40.0f;

	public float maxZoomFactor = 0.6f;

	void Awake() {
		cam = GetComponent<tk2dCamera>();
	}

	void FixedUpdate() {
		Vector3 aux = target.position;
		aux.z = transform.position.z;
		aux.y = transform.position.y;
		transform.position = aux;

	
	}
}
