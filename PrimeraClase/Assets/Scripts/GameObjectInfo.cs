using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectInfo : MonoBehaviour {
    public float duracion = 5;


    void Start () {
        string goName = gameObject.name;
        Debug.Log(goName);
       
        Debug.Log("El game object " + goName + " se autodestruira en "+ duracion + " segundos.");
        Destroy(gameObject.gameObject, duracion);
        
	}

    private void OnDestroy()
    {
        Debug.Log("Taluego");
    }


}
