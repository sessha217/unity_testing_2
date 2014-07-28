using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	public GameObject player;
	public Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position;
	}

	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
