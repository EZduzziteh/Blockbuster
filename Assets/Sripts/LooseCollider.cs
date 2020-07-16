using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {
    
	public LevelManager Levelmanager;

    void OnTriggerEnter2D(Collider2D trigger)
    {
		Levelmanager.LifeCheck();

    }
}
