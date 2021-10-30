using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    float fallSpeed;

    // Start is called before the first frame update
    void Start()
    {
        this.fallSpeed = 0.01f + 0.01f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);

        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }
}
