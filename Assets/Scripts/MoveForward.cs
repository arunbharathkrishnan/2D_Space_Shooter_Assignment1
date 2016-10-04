using UnityEngine;
using System.Collections;
/*
 * Author Name : Arun Bharath Krishnan
 * Last Modified on : 03-oct-2016
 * Last Modified by : Arun Bharath Krishnan
 * Program Description : Move forward.
 * 
 */
public class MoveForward : MonoBehaviour {

	public float maxSpeed = 5f;

	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		
		Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);
		
		pos += transform.rotation * velocity;

		transform.position = pos;
	}
}
