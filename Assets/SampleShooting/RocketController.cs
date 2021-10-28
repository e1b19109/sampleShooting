using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RocketController : MonoBehaviour {

	public GameObject bulletPrefab;

	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)&transform.position.x > -9.0f) {
			transform.Translate (-0.1f, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)&transform.position.x < 9.0f) {
			transform.Translate ( 0.1f, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (bulletPrefab, transform.position, Quaternion.identity);
		}
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Rock")
        {
            Destroy(coll.gameObject);
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            Destroy(gameObject);
        }

    }
}
