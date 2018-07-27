using UnityEngine;

public class PowerUp : MonoBehaviour 
{
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
