using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{

    public GameObject explosionPrefab;

    void Update()
    {
        transform.Translate(0, 0.2f, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {

            if (coll.gameObject.tag == "Rock")
            {
                // �Փ˂����Ƃ��ɃX�R�A���X�V����
                GameObject.Find("Canvas").GetComponent<UIController>().AddScore();

                // �����G�t�F�N�g�𐶐�����	
                GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
                Destroy(effect, 1.0f);

                Destroy(coll.gameObject);
                Destroy(gameObject);
            }
	    if (coll.gameObject.tag == "Gem")
            {
                // �Փ˂����Ƃ��ɃX�R�A���X�V����
                GameObject.Find("Canvas").GetComponent<UIController>().GemAddScore();

                // �����G�t�F�N�g�𐶐�����	
                GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
                Destroy(effect, 1.0f);

                Destroy(coll.gameObject);
                Destroy(gameObject);
            }
        
    }
}
