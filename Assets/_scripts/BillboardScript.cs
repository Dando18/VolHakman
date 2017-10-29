using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardScript : MonoBehaviour {


    private Camera cam;

    void Awake()
    {
        cam = Camera.main;
    }

	void LateUpdate()
    {
        transform.LookAt(transform.position + cam.transform.rotation * Vector3.down,
            cam.transform.rotation * Vector3.back);
        
    }
}
