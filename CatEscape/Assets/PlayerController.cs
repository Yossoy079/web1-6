using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    int leftMove = -2;
    int rightMove = 2;
    int endLeftMove = -8;
    int endRightMove = 8;

    int movePoint = 0;
    bool leftEnd = false;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LButtonDown();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RButtonDown();
        }
	}

    public void LButtonDown()
    {
        if (this.transform.position.x > endLeftMove)
        {
            transform.Translate(leftMove, 0, 0);
            if (this.transform.position.x <= endLeftMove && leftEnd == false)
            {
                movePoint += 1;
                leftEnd = true;
            }
        }
    }
    public void RButtonDown()
    {
        if (this.transform.position.x < endRightMove)
        {
            transform.Translate(rightMove, 0, 0);
            if (this.transform.position.x >= endRightMove && leftEnd == true)
            {
                movePoint += 1;
                leftEnd = false;
            }
        }
    }

    public int GetMovePoint()
    {
        return movePoint;
    }

    public bool GetLeftDirection()
    {
        return leftEnd;
    }
}
