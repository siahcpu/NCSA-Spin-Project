using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotational : MonoBehaviour {
	public GameObject camera;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(Time.deltaTime*10,0,0));
		transform.RotateAround (camera.transform.position, camera.transform.up, 10 * Time.deltaTime);
	}
}
