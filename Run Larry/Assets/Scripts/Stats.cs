using TMPro;
using UnityEngine;

public class Stats : MonoBehaviour 
{
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
