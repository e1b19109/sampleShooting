using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {
		
	private AudioSource sound01;
	GameObject rocket1;
	RocketController rocket2;


	void Start () {
		//AudioSourceコンポーネントを取得し、変数に格納
		sound01 = GetComponent<AudioSource>();
		//RocketControllerの弾数を取得、格納
		rocket1 = GameObject.Find("rocket");
		Debug.Log(rocket1);
		rocket2 = rocket1.GetComponent<RocketController>();
	}
	
	void Update () {
		//指定のキーが押されたら音声ファイル再生
		if (rocket2.i > 0){
			if (Input.GetKeyDown(KeyCode.Space)){
				sound01.PlayOneShot(sound01.clip);
			}
		}
		
	}
}