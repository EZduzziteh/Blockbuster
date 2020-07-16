using UnityEngine;
using System.Collections;

public class Ball1 : MonoBehaviour {
    private Paddle paddle;
    private bool hasStarted = false;
    private Vector3 paddleToBallVector;

	// Use this for initialization


	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                //print("Mouse Clicked, Launch Ball.");
                hasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-6, 6), 5f);
            }
        }
	
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 tweak = new Vector2 (Random.Range(0f, 0.2f), Random.Range(0f,0.2f));
        if (hasStarted)
        {
            GetComponent<AudioSource>().Play();
           this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }
}
