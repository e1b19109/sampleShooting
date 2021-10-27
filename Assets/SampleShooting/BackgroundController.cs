using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour
{

    void Update()
    {
        transform.Translate(0, -0.03f, 0);
        if (transform.position.y < -13.9f)
        {
            transform.position = new Vector3(0, 13.9f, 0);
        }
    }
}
