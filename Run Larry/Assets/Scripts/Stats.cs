using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Stats : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (gameObject.name == "CoinText")
        {
            GetComponent<TextMeshPro>().text = "Coins : " + GameManager.coinTotal;
        }if (gameObject.name == "TimeText")
        {
            GetComponent<TextMeshPro>().text = "Time : " + Mathf.RoundToInt(GameManager.timeTotal);
        }if (gameObject.name == "StatsText")
        {
            GetComponent<TextMeshPro>().text = GameManager.lvlCompStatus;
            if (GameManager.lvlCompStatus == "Fail")
            {
                GameObject.Find("LevelComplete").GetComponent<TextMeshPro>().text = "You Died";
            }
        }
	}
}
