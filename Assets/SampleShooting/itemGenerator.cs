using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemGenerator : MonoBehaviour
{
    public GameObject itemPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenRock", 1, 10);
    }

    // Update is called once per frame
    void GenRock()
    {
        Instantiate(itemPrefab, new Vector3 (-9f + 16 * Random.value, 6, 0), Quaternion.identity);
    }
}
