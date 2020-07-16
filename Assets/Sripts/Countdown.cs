using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {
    public float TimeLeft;
    public Text text;
	// Use this for initialization
	void Start () {

        TimeLeft = 3.5f;

	}
	
	// Update is called once per frame
	void Update () {
        TimeLeft -= Time.deltaTime;
        if (TimeLeft <= 0)
        {
            text.text = "Click to Begin";
        }
	}
}
