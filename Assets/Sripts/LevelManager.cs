using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public static int maxlives;
	public GameObject Life1;
	public GameObject Life2;
	public GameObject Life3;
	public GameObject Life0;
	public GameObject Life4;

	public bool cursorVisible=false;
	private void Start()
	{
		if (cursorVisible)
		{

			Cursor.visible = true;

		}
		else
		{

			Cursor.visible = false;

		}
	}


	public void LoadLevel(string name)
    {
		
		Brick.BrickCount = 0;
		//ResetLives ();
        //Debug.Log("Level load requested for:" + name);
        SceneManager.LoadScene(name);
    }
	//Quits application
    public void Quitrequest(string quit)
    {
	   //Debug.Log("Request sent to quit");
        Application.Quit();
    }

	public void Update(){
		LifeUI ();
	}


	public void LifeUI(){
		if(maxlives==5){
			Life1.active = true;
			Life2.active = true;
			Life3.active = true;
			Life0.active = true;
			Life4.active = true;
		}
		if(maxlives==4){
			Life1.active = true;
			Life2.active = true;
			Life3.active = true;
			Life0.active = true;
			Life4.active = false;
		}
		if (maxlives == 3) {
			Life1.active = true;
			Life2.active = true;
			Life3.active = true;
			Life0.active = false;
			Life4.active = false;
		} else if (maxlives == 2) {
			Life1.active = true;
			Life2.active = true;
			Life3.active = false;
			Life0.active = false;
			Life4.active = false;
		} else if (maxlives == 1) {
			Life1.active = true;
			Life2.active = false;
			Life3.active = false;
			Life0.active = false;
			Life4.active = false;
		} 
			
	}



	//Loads next level
    public void LoadNextLevel()
    {

        Brick.BrickCount = 0;
		//ResetLives ();
        SceneManager.LoadScene( (SceneManager.GetActiveScene().buildIndex + 1));



    }


    
	//Resets Amount of lives
	public void ResetLives(){
	maxlives = 3;
	}


	//Reloads Current Level
	public void ReloadLevel(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		Brick.BrickCount = 0;

	}


		
		public void LifeCheck (){
		maxlives--;
		if(maxlives==0){
		SceneManager.LoadScene ("Loose Screen");
			}else{
			ReloadLevel ();

			}
	}

 

}
