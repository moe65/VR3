using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour {

	Rigidbody rb;
	private Animator animator;
	bool ground;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
/*		if(ground){
			if(Input.GetKey(KeyCode.UpArrow)){
				animator.SetBool("Jump")
			}}
*/
	//		else{

		animator.SetBool ("Sit", true);
	//		
	}

	void OnCollisonStay (Collision col){
		ground = true;
	}
}
