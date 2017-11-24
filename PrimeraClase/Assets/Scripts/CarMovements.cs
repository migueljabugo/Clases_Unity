using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovements : MonoBehaviour {

    public float speed = 20;
    public float Depth;

    public float rotationAxis;


    void Update () {

        Depth = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0, 0, Depth);
        movement = movement.normalized * speed * Time.deltaTime;
        transform.Translate(movement);


        if (Depth > 0f)
        {
            rotationAxis = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up, rotationAxis * 100 * Time.deltaTime);
        }else if (Depth < 0f)
        {
            rotationAxis = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up, -rotationAxis * 100 * Time.deltaTime);
        }
    }
}
