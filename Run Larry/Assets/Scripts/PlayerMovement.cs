using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour 
{
    public KeyCode moveL;
    public KeyCode moveR;

    public float horizVel = 0;
    public int laneNum = 2;
    public string controlLocked = "n";
    public Transform boomObj;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, GameManager.vertVel, 4);
	
        if (Input.GetKeyDown(moveL) && laneNum > 1 && controlLocked == "n")
        {
            horizVel = -2;
            StartCoroutine(StopSlide());
            laneNum -= 1;
            controlLocked = "y";
        }if (Input.GetKeyDown(moveR) && laneNum < 3 && controlLocked == "n")
        {
            horizVel = 2;
            StartCoroutine(StopSlide());
            laneNum += 1;
            controlLocked = "y";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lethal"))
        {
            gameObject.SetActive(false);
            GameManager.zVelAdj = 0;
            Instantiate(boomObj, transform.position, boomObj.rotation);
            GameManager.lvlCompStatus = "Fail";
        }if (collision.gameObject.name == "Capsule")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "RampBottomTrig")
        {
            GameManager.vertVel = 1.5f;
        }if (other.gameObject.name == "RampTopTrig")
        {
            GameManager.vertVel = 0;
        }if (other.gameObject.name == "Exit")
        {
            SceneManager.LoadScene(1);
            GameManager.lvlCompStatus = "Sucess";
        }if (other.gameObject.name == "Coin(Clone)")
        {
            Destroy(other.gameObject);
            GameManager.coinTotal++;
        }
        if (other.gameObject.name == "Capsule")
        {
            Destroy(other.gameObject);
        }
    }

    IEnumerator StopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        controlLocked = "n";
    }
}
