using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatScript : MonoBehaviour {

	public LayerMask food;

    public LayerMask enemy;

	private int score = 0;

	void OnTriggerEnter(Collider col) {
		if((food.value & (1 << col.gameObject.layer)) > 0) {
			Destroy (col.gameObject);
			print ("score: " + score++);
		} else if ((enemy.value & (1 << col.gameObject.layer)) > 0)
        {
            GetComponent<LivesScript>().Hurt();
            print("lives: " + GetComponent<LivesScript>().GetLives());
        }
	}

    public int GetScore()
    {
        return score;
    }
}
