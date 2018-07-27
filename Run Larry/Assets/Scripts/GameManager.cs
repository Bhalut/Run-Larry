using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float vertVel = 0;
    public static float timeTotal = 0;
    public static int coinTotal = 0;
    public float waittoload = 0;

    public float zScenePos = 58;

    public static float zVelAdj = 1;

    public static string lvlCompStatus = "";

    public Transform bbNoPit;
    public Transform bbPitMid;

    public Transform obstaculeObj;
    public Transform powerUpObj;
    public Transform coinObj;

    public int randNum;

    // Use this for initialization
    void Start()
    {
        coinTotal = 0;
        timeTotal = 0;

        Instantiate(bbNoPit, new Vector3(0, 2, 42), bbNoPit.rotation);
        Instantiate(bbNoPit, new Vector3(0, 2, 46), bbNoPit.rotation);

        Instantiate(bbPitMid, new Vector3(0, 2, 50), bbPitMid.rotation);
        Instantiate(bbPitMid, new Vector3(0, 2, 54), bbPitMid.rotation);
    }



    // Update is called once per frame
    void Update()
    {
        if (zScenePos < 120)
        {
            randNum = Random.Range(0, 10);

            if (randNum < 3)
            {
                Instantiate(coinObj, new Vector3(-1, 3, zScenePos), coinObj.rotation);
            }
            if (randNum < 7)
            {
                Instantiate(coinObj, new Vector3(1, 3, zScenePos), coinObj.rotation);
            }
            if (randNum == 4)
            {
                Instantiate(obstaculeObj, new Vector3(1, 3, zScenePos), obstaculeObj.rotation);
            }
            if (randNum == 5)
            {
                Instantiate(obstaculeObj, new Vector3(0, 3, zScenePos), obstaculeObj.rotation);
            }

            Instantiate(bbNoPit, new Vector3(0, 2, zScenePos), bbNoPit.rotation);
            zScenePos += 4;
        }

        timeTotal += Time.deltaTime;

        if (lvlCompStatus == "Fail")
        {
            waittoload += Time.deltaTime;
            if (waittoload > 2)
            {
                
                SceneManager.LoadScene(1);
            }
        }
    }


}
