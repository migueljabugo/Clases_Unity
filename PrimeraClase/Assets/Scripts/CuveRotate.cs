using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuveRotate : MonoBehaviour {

    /*
    //Recogiendo cada tecla para el movimiento
    public float angles = 100;
    public Vector3 axis = Vector3.up;
    public bool rotateRight;
    public bool rotateLeft;
    */

    public float rotationAxis;
    public float speed = 100;


    void Start () {
		
	}
	

	void Update () {

        rotationAxis = Input.GetAxis("Rotation");

        transform.Rotate(Vector3.up, rotationAxis * speed * Time.deltaTime);



        /*
        //Recogiendo cada tecla para el movimiento
        rotateRight = Input.GetKey(KeyCode.E);
        rotateLeft = Input.GetKey(KeyCode.Q);

        if (rotateRight)
        {
            gameObject.transform.Rotate(axis, angles * Time.deltaTime);
        }else if (rotateLeft)
        {
            gameObject.transform.Rotate(axis, -1 * angles * Time.deltaTime);
        }
        */
    }
}
