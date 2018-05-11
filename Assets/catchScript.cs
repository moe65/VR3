using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class catchScript : MonoBehaviour {

	public static int point = 0;
	public Text pointLabel;

	public AudioClip catchSound;
	public GameObject explosion;
	public GameObject sparks;
	public GameObject ink;
	AudioSource audioSource;
	RaycastHit hit;


	// ゲームが始まった時に1回呼ばれるメソッド
	void Start () {
		audioSource = gameObject.AddComponent<AudioSource> ();
		audioSource.clip = catchSound;
	}

	// ゲームの1フレームごとに呼ばれるメソッド
	void Update () {
		pointLabel.text = "キャッチできたボール数" + point.ToString ();

		if (Input.GetMouseButtonDown (1)) {
				audioSource.Play ();
				Catch ();
				//Instantiate (explosion, transform.position, Quaternion.identity);
			}
		}
		
	// 銃をうつ時に行いたいことをこの中に書く
	void Catch(){
		Vector3 center = new Vector3(Screen.width/2,Screen.height/2,0);
		Ray ray = Camera.main.ScreenPointToRay(center);
		float distance = 50f;
		if (Physics.Raycast (ray, out hit, distance)) {
			Instantiate (sparks, hit.point, Quaternion.identity);
			//Destroy (hit.gameObject);
			}

		}
	}
	
