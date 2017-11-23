using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuveMovements : MonoBehaviour
{
    /*
    //Forma preguntando por cada tecla pulsada
    public bool forward;    // W
    public bool back;       // S
    public bool right;      // D
    public bool left;       // A
    */


    public float speed = 20;
    private float Depth;
    private float horizontal;


    void Start()
    {

    }


    void Update()
    {
        Depth = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        transform.position += transform.forward * Depth * speed * Time.deltaTime;

        transform.position += transform.right * horizontal * speed * Time.deltaTime;


        /* 
         //Forma preguntando por cada tecla pulsada
         forward = Input.GetKey(KeyCode.W);
         back = Input.GetKey(KeyCode.S);
         right = Input.GetKey(KeyCode.D);
         left = Input.GetKey(KeyCode.A);

         if (forward)
         {
             transform.position += transform.forward * speed * Time.deltaTime;
         }else if (back)
         {
             transform.position += -transform.forward * speed * Time.deltaTime;
         }

         if (right)
         {
             transform.position += transform.right * speed * Time.deltaTime;
         }else if (left)
         {
             transform.position += -transform.right * speed * Time.deltaTime;
         }
         */

    }
}
