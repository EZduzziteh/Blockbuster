using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
    
    public int timesHit;
    public static int BrickCount = 0;
    public AudioClip Crack;
	public Sprite[] hitSprites;


    private bool isBreakable;
    private LevelManager levelManager;
    //#TODO implement states public Sprite[] hitSprites;
	// Use this for initialization
	void Start () {

       
        
        isBreakable = (this.tag == "Breakable");
        //#TODO Keep track of breakables
        if (isBreakable)
        {
            BrickCount++;
			print(BrickCount);
        }
        timesHit = 0;
        levelManager = FindObjectOfType<LevelManager>();
	
	}

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("handlehit");
        HandleHits();

    }*/


    void OnCollisionEnter2D(Collision2D col)
        {
         AudioSource.PlayClipAtPoint(Crack, transform.position, 0.5f);
        if (isBreakable)
        {
            HandleHits();
        }
        

       
        }
    void HandleHits()
    {

     	    timesHit++;
		int maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits) {
			BrickCount--;



		} 


            
            Destroy(gameObject);
            if (BrickCount <= 0)
            {
                levelManager.LoadNextLevel();
		}else {
			LoadSprites();
		}
        
		void LoadSprites () {
			int spriteIndex = timesHit - 1;

			if (hitSprites[spriteIndex] != null) {
				this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
			} else {
				Debug.LogError ("Brick sprite missing");
			}
		}
    

    }
   


}
