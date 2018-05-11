using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("loadScene1", 10f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void loadScene1(){
		SceneManager.LoadScene ("breakfast1");
	}
}
