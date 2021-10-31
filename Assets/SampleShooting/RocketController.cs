using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RocketController : MonoBehaviour {

	public GameObject bulletPrefab;
    public int i = 10;

	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)&transform.position.x > -9.0f) {
			transform.Translate (-0.1f, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)&transform.position.x < 9.0f) {
			transform.Translate ( 0.1f, 0, 0);
		}

        //‹Ê‚Ìˆ—
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (i > 0)
            {
                Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                i--;
            }
            else {
                i = 0;
            }
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
	if (coll.gameObject.tag == "item")
        {
            i += 5;
            Destroy(coll.gameObject);
        }
    }
}
