using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransform : MonoBehaviour {

    public Vector3 global;
    public Vector3 local;


	void Update () {
        global = transform.position;
        local = transform.localPosition;
	}
}
