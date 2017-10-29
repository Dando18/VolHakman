using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour {

    public LayerMask waypoint;
    public float speed = 1f;
    public WayPointScript initial;

    private WayPointScript to;
    private WayPointScript from;

	void Start() {
        to = initial;
        from = initial;
	}

    void Update() {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, to.transform.position, step);


        Vector3 diff = (to.transform.position - from.transform.position).normalized;
        //diff.x = 0;
        Quaternion target = Quaternion.LookRotation(diff);
        target *= Quaternion.Euler(90, 0, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, target, 10 * Time.deltaTime);


        // If it has arrived, find new transform
        if (to.transform.position == transform.position)
        {
            WayPointScript tmp;
            do
            {
                tmp = to.getRandomNeighbor();
            } while (tmp.transform.position == from.transform.position);
            from = to;
            to = tmp;
        }
    }
}
