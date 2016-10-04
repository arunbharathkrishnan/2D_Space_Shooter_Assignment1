using UnityEngine;
using System.Collections;
/*
 * Author Name : Arun Bharath Krishnan
 * Last Modified on : 03-oct-2016
 * Last Modified by : Arun Bharath Krishnan
 * Program Description : Destroy game object when times expires.
 * 
 */
public class SelfDestruct : MonoBehaviour {

	public float timer = 1f;

	void Update () {
		timer -= Time.deltaTime;

        // destroy the game if time ends
		if(timer <= 0) {
			Destroy(gameObject);
		}
	}
}
