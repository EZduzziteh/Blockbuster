using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesCanvas : MonoBehaviour {
	public GameObject lifepowerup;
	public Transform PowerUpSpawnPoints;
	private Transform[] spawnPoints;
	private bool hasspawned;
	private bool lifecapacity;

	void Start(){
		SpawnPowerUp();
	}


	void Update () {
		if (LevelManager.maxlives < 5){
			lifecapacity = false;
		}else{
			lifecapacity = true;
		}
		if (!hasspawned && !lifecapacity) {
			Spawn ();
			hasspawned = true;
		}


	}

	//Gets random position from within possible spawnpoints
	private void Spawn(){
		int i = Random.Range (1, spawnPoints.Length);


	}

	void SpawnPowerUp()
	{
		spawnPoints = PowerUpSpawnPoints.GetComponentsInChildren<Transform>();
		int Randamount = Random.Range(1, 100);

		if (Randamount < 20)
		{
			hasspawned = false;

		}
		else
		{
			hasspawned = true;

		}
	}

}
