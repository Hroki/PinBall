using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	//ボールが見える可能性のあるz軸の最大値
	private float visiblePosZ = -6.5f;

	//ゲームオーバを表示するテキスト
	private GameObject gameoverText;
	private GameObject pointText;

	int allpoint = 0;


	// Use this for initialization
	void Start () {
		//シーン中のGameOverTextオブジェクトを取得
		this.gameoverText = GameObject.Find ("GameOverText");
		this.pointText = GameObject.Find ("PointText");
	}

	void OnCollisionEnter(Collision other) {

		Debug.Log ("ああ");
		if (other.gameObject.tag == "SmallStarTag") {
			allpoint += 10;
		} else if (other.gameObject.tag == "LargeStarTag") {
			allpoint += 30;
		} else if (other.gameObject.tag == "SmallCloudTag") {
			allpoint += 30;
		} else if (other.gameObject.tag == "LargeCloudTag") {
			allpoint += 50; 
		}
		this.pointText.GetComponent<Text> ().text = allpoint.ToString ();
    }
	// Update is called once per frame
	void Update () {
		//ボールが画面外に出た場合
		if (this.transform.position.z < this.visiblePosZ) {
			//GameoverTextにゲームオーバを表示
			this.gameoverText.GetComponent<Text> ().text = "Game Over";
		}
			
	}
}





	

	

		
				
