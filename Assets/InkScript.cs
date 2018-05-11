using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkScript : MonoBehaviour {
	
	[SerializeField]
	private GameObject[] inkPaints;

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.CompareTag("Enemy")){
			other.gameObject.SendMessage ("Damage");
			Destroy (gameObject);
			return;
		}
		var contact = other.contacts [0];
		var pos = contact.point + contact.normal * 0.1f;
		var ink = Instantiate (inkPaints [Random.Range (0, inkPaints.Length)], pos, Quaternion.identity);
		ink.transform.LookAt (contact.point + contact.normal);
		Destroy (gameObject);
	}
}
	// Use this for initialization
	
