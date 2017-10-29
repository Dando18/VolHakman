using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverScript : MonoBehaviour {


	public float amplitude = 3f;
	public float speed = 1f;

	private float y0 = 0f;


	// Use this for initialization
	void Start () {
		y0 = transform.position.y;
		speed += Random.value;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(
			transform.position.x, 
			y0 + amplitude * Mathf.Sin (speed * Time.time), 
			transform.position.z);
	}
}
