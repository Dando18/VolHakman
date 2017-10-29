using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointScript : MonoBehaviour {

	public Transform[] neighbors;

	public WayPointScript getRandomNeighbor() {
		return neighbors [Random.Range (0, neighbors.Length)].gameObject.GetComponent<WayPointScript>();
	}


}
