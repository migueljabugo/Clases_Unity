using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour {

    public float angles = 30;
    public Vector3 axis;


    void Start () {
        
	}


    void Update () {
        gameObject.transform.Rotate(axis, angles * Time.deltaTime);
	}
}
