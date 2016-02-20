using UnityEngine;
using System.Collections;

public class folled : MonoBehaviour {
	void foll (){
		GetComponent<Rigidbody>().useGravity = true;
	}


	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
