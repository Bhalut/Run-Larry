using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float vertVel = 0;
    public static float timeTotal = 0;
    public static int coinTotal = 0;
    public float waittoload = 0;

    public float zScenePos = 58;

    public static float zVelAdj = 0;

    public static string lvlCompStatus = "";

    public Transform bbNoPit;

    public Transform obstaculeObj;
    public Transform powerUpObj;
    public Transform coinObj;

    void Start()
    {
        coinTotal = 0;
        timeTotal = 0;
        zVelAdj = 1;

        lvlCompStatus = "Success";

        Instantiate(bbNoPit, new Vector3(0, 2, 42), bbNoPit.rotation);
        Instantiate(bbNoPit, new Vector3(0, 2, 46), bbNoPit.rotation);

        Instantiate(bbNoPit, new Vector3(0, 2, 50), bbNoPit.rotation);
        Instantiate(bbNoPit, new Vector3(0, 2, 54), bbNoPit.rotation);
    }
    
    void Update()
    {
        if (zScenePos < 120)
        {
            randNum = Random.Range(0, 9);

            if (randNum == 1)
            {
                Instantiate(coinObj, new Vector3(-1, 3, zScenePos), coinObj.rotation);
            }
            if (randNum == 2)
            {
                Instantiate(coinObj, new Vector3(1, 3, zScenePos), coinObj.rotation);
            }
            if (randNum == 0)
            {
                Instantiate(obstaculeObj, new Vector3(1, 3, zScenePos), obstaculeObj.rotation);
                Instantiate(coinObj, new Vector3(0, 3, zScenePos), coinObj.rotation);
            }
            if (randNum == 3)
            {
                Instantiate(obstaculeObj, new Vector3(-1, 3, zScenePos), obstaculeObj.rotation);
            }
            if (randNum == 4)
            {
                Instantiate(obstaculeObj, new Vector3(0, 3, zScenePos), obstaculeObj.rotation);
                Instantiate(coinObj, new Vector3(-1, 3, zScenePos), coinObj.rotation);
            }
            if (randNum == 5)
            {
                Instantiate(obstaculeObj, new Vector3(1, 3, zScenePos), obstaculeObj.rotation);
                Instantiate(coinObj, new Vector3(0, 3, zScenePos), coinObj.rotation);
            }
            if (randNum == 6)
            {
                Instantiate(obstaculeObj, new Vector3(0, 3, zScenePos), obstaculeObj.rotation);
                Instantiate(coinObj, new Vector3(1, 3, zScenePos), coinObj.rotation);
            }
            if (randNum == 7)
            {
                Instantiate(obstaculeObj, new Vector3(1, 3, zScenePos), obstaculeObj.rotation);
            }
            if (randNum == 8)
            {
                Instantiate(obstaculeObj, new Vector3(-1, 3, zScenePos), obstaculeObj.rotation);
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
