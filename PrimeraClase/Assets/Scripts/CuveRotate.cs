using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuveRotate : MonoBehaviour {

    public float angles = 100;
    public Vector3 axis = Vector3.up;
    public bool rotateRight;
    public bool rotateLeft;


    void Start () {
		
	}
	

	void Update () {
        rotateRight = Input.GetKey(KeyCode.E);
        rotateLeft = Input.GetKey(KeyCode.Q);

        if (rotateRight)
        {
            gameObject.transform.Rotate(axis, angles * Time.deltaTime);
        }else if (rotateLeft)
        {
            gameObject.transform.Rotate(axis, -1 * angles * Time.deltaTime);
        }

        
    }
}
