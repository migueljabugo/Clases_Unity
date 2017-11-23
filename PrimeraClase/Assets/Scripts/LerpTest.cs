using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTest : MonoBehaviour {

    public Vector3 a;
    public Vector3 b;
    [Range(0,1)]
    public float progress = 0;

	

	void Update () {
        transform.position = Vector3.Lerp(a, b, progress);
        //transform.position = Vector3.LerpUnclamped(a, b, progress);
    }
}
