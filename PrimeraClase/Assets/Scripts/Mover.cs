using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    private Transform myTransform;
    public Vector3 sum;

    void Start () {
        myTransform = gameObject.GetComponent<Transform>();
        Vector3 pos = myTransform.position;
        pos += sum;
        myTransform.position = pos;

	}
	

}
