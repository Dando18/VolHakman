using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour {

	public Transform location;

	void OnTriggerEnter(Collider col) {
		col.transform.position = location.position;
		col.transform.rotation = location.rotation;
	}
}
