using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (gameObject.name == "Capsule")
        {
            transform.Rotate(0, 2.5f, 0);
        }if (gameObject.name == "Coin(Clone)")
        {
            transform.Rotate(0, 3.5f, 0);
        }
	}
}
