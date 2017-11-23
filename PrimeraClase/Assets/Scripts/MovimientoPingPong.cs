using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPingPong : MonoBehaviour {

    public Vector3 maxScale;
    public Vector3 minScale;
    public float speed = 1f;

    private bool up;
    float i = 0;

    void start()
    {
        up = true;
        transform.localScale = minScale;
    }

    void Update()
    {
        if (up)
        {
            transform.position = Vector3.Lerp(minScale, maxScale, i);
        }
        else
        {
            transform.position = Vector3.Lerp(maxScale, minScale, i);
        }

        i += Time.deltaTime * speed;
        if (i >= 1)
        {
            i = 0;
            up = !up;
        }
    }
}
