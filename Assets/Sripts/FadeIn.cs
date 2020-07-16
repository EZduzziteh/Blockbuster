using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeIn : MonoBehaviour {
    public float FadeTimer=3;
    private Image FadeScreen;
    private Color CurrentColor=Color.black;
	// Use this for initialization
	void Start () {
        FadeScreen = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad < FadeTimer)
        {
            //Fade In
            float AlphaChange = Time.deltaTime / FadeTimer;
            CurrentColor.a -=AlphaChange;
            FadeScreen.color = CurrentColor;
                

        }else
        {
            gameObject.SetActive ( false);
        }
	}
}
