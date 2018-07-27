using UnityEngine;

public class CameraController : MonoBehaviour 
{
	void Update () 
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, GameManager.vertVel, 4 * GameManager.zVelAdj);
	}
}
