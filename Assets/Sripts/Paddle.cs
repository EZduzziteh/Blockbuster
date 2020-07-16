using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    public bool Autoplay = false;
    private Ball1 ball;
	// Use this for initialization
	void Start () {
        ball = FindObjectOfType<Ball1>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (!Autoplay)
        {
            MoveWithMouse();

        }else
        {
            AutoMove();
        }

    }



    void MoveWithMouse()
    {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		float ballPos = Input.mousePosition.x / Screen.width * 16-8;
		paddlePos.x = Mathf.Clamp(ballPos, -3.4f, 3.4f);
		this.transform.position = paddlePos;
    }
    void AutoMove()
    {
        Vector3 paddlePos = new Vector3(-3.4f, +this.transform.position.y, 0f);
        Vector3 ballPos = ball.transform.position;
        paddlePos.x = Mathf.Clamp(ballPos.x, -3.4f, 3.4f);
        this.transform.position = paddlePos;
    }
}
