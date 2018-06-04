using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject hpGauge;
    GameObject textPoint;
    GameObject textDirection;
    GameObject player;
    int life = 10;

    // Use this for initialization
    void Start () {
        this.hpGauge = GameObject.Find("hpGauge");
        this.textPoint = GameObject.Find("textPoint");
        this.textDirection = GameObject.Find("textDirection");
        this.player = GameObject.Find("player");
	}

    void Update()
    {
        int points = this.player.GetComponent<PlayerController>().GetMovePoint();
        if (this.player.GetComponent<PlayerController>().GetLeftDirection())
        {
            this.textDirection.GetComponent<Text>().text = "右端を目指せ！";
        }
        else
        {
            this.textDirection.GetComponent<Text>().text = "左端を目指せ！";
        }
        this.textPoint.GetComponent<Text>().text = "points:" + points.ToString();
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        life -= 1;
        if(life <= 0)
        {
            Application.Quit();
        }
    }

}
