using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

    GameObject player;

    Vector2 p1;
    Vector2 p2;
    Vector2 dir;

    float r1 = 0.5f; //矢の半径
    float r2 = 1.0f; //プレイヤの半径
    float speed = -0.2f; //矢の落下速度

    // Use this for initialization
    void Start () {
        this.player = GameObject.Find("player");
    }
	
	// Update is called once per frame
	void Update () {
        //フレームごとに等速で落下させる
        transform.Translate(0, speed, 0);

        //画面外に出たらオブジェクトを破壊
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        p1 = transform.position;
        p2 = this.player.transform.position;
        dir = p1 - p2;

        if (dir.magnitude < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            Destroy(gameObject); //衝突した場合は矢を消す
        }
	}
}
