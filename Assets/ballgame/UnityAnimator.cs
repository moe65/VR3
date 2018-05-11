using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityAnimator : MonoBehaviour {
	public GameObject[] balls;
	private Animator anim;
	public static int ball = 5;
	public Text ballLabel;

	void Start(){
		anim = GetComponent<Animator> ();
		//StartCoroutine ("Sample");  

	}

	void Wait(){
		anim.SetTrigger ("wait");
	}

	void Play(){
		anim.SetTrigger ("jump");
	}



	void Update () {
		
		/*if (Input.GetMouseButtonDown (0)) {
			Shot ();
			ball--;
		}*/
		ballLabel.text = "残りのボール数:" + ball.ToString ();


/*		if (Input.GetMouseButtonDown (0)) {
			anim.SetBool ("handshake",true);
		
		}if (Input.GetMouseButtonUp(0)) {
			anim.SetBool ("handshake",false);
		}
*/
	}
	// コルーチン  
	private IEnumerator Sample() {  
		// コルーチンの処理  
		yield return new WaitForSeconds (1.0f);
		yield return StartCoroutine ("Sample2");
		yield break;
	}

	private IEnumerator Sample2(){
		anim.SetTrigger("greet2");
		yield break;
		yield return new WaitForSeconds (1.0f);
		yield return StartCoroutine ("Sample2");
	}
	private IEnumerator Sample3(){
		anim.SetTrigger("wait");
		yield break;
		yield return new WaitForSeconds (3.0f);
	}

		void Shot(){
		Invoke ("Shotball", 0.5f);
		anim.SetBool("greet1",true);
	
		Invoke ("startRotation", 2f);
		}


	void Shotball(){
		/*var rand = Random.Range (1, 100);
		if (rand < 30) {
			transform.Rotate (0, 20, 0);
		} else if (rand < 60) {
			transform.Rotate (0, -20, 0);
		} else {
			transform.Rotate (0, 0, 0);
		}
		var ballInstance = Instantiate (balls [Random.Range (0, balls.Length)], transform.position + new Vector3 (-2, 3, 0), transform.rotation);
		Rigidbody rb = ballInstance.GetComponent<Rigidbody> ();
		print ("rigidbody");
		rb.AddForce (ballInstance.transform.forward * 500f);
		Destroy (ballInstance, 10f);
*/
	}

	void startRotation(){
		transform.rotation=Quaternion.Euler(0,250,0);
	}
}



	
