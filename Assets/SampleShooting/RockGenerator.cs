using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGenerator : MonoBehaviour
{
    public GameObject rockPrefab;
    GameObject canvas;
    UIController gameFinish1;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("GenRock", 1, 1);
	InvokeRepeating("GenRock", 10, 1);
	InvokeRepeating("GenRock", 20, 1);
	InvokeRepeating("GenRock", 30, 1);
	InvokeRepeating("GenRock", 40, 1);
	InvokeRepeating("GenRock", 50, 1);
        canvas = GameObject.Find("Canvas");
        Debug.Log(canvas);
        gameFinish1 = canvas.GetComponent<UIController>();
    }

    // Update is called once per frame
    void GenRock()
    {
        if (gameFinish1.gameFinish== true)
        {
            return;
        }
        Instantiate(rockPrefab, new Vector3 (-9f + 20 * Random.value, 6, 0), Quaternion.identity);
    }
}
