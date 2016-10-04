using UnityEngine;
using System.Collections;
/*
 * Author Name : Arun Bharath Krishnan
 * Last Modified on : 03-oct-2016
 * Last Modified by : Arun Bharath Krishnan
 * Program Description : Shooting game plays.
 * 
 */
public class PlayerShooting : MonoBehaviour {

	public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

	public GameObject bulletPrefab;
	int bulletLayer;

	public float fireDelay = 0.25f;
	float cooldownTimer = 0;

    public GUIText scoreTest;
    public int score;

	void Start() {

        score = 0;
        //updateScore();
		bulletLayer = gameObject.layer;
	}

	// Update is called once per frame
	void Update () {
		cooldownTimer -= Time.deltaTime;

		if( Input.GetButton("Fire1") && cooldownTimer <= 0 ) {
			// SHOOT!
			cooldownTimer = fireDelay;

			Vector3 offset = transform.rotation * bulletOffset;

			GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            
			bulletGO.layer = bulletLayer;
           
		}
	}

    //void updateScore()
    //{
    //    scoreTest.text = "score:" + score;
    //}

    //public void addscore(int newScoreValue)
    //{
    //    score += newScoreValue;
    //    updateScore();
    //}
}
