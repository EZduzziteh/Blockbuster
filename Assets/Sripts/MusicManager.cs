using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MusicManager : MonoBehaviour {
    private AudioSource Music;
    public AudioClip[] LevelMusic;
    // Use this for initialization
    void Awake() {

        DontDestroyOnLoad(gameObject);
       // Debug.Log("Dont Destroy on load " + name);


	}
	void Start()
    {
        int LevelIndex = SceneManager.GetActiveScene().buildIndex;
        Music = GetComponent<AudioSource>();
    }
	// Update is called once per frame
	void OnLevelWasLoaded(int LevelIndex) {
        AudioClip ThisLevelMusic = LevelMusic[LevelIndex];
       // Debug.Log("Playing Clip " + ThisLevelMusic);
        if (ThisLevelMusic) {
            Music.clip = ThisLevelMusic;
            Music.loop = true;
            Music.Play();
        }
	}

}