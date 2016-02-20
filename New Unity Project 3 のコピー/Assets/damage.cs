using UnityEngine;
using System.Collections;

public class damage : MonoBehaviour {
	public GameObject dg;
	// Use this for initialization
	void Start () {
		dg.GetComponent<Renderer>().enabled = false;
	}
	void OnControllerColliderHit(ControllerColliderHit hit){
		if(hit.gameObject.tag == "follobject"){
			//sDebug.Log ("fooooooooooooo!!!!!!!!!!");
			dg.GetComponent<Renderer>().enabled =true ;

		}
	}

	// Update is called once per frame
	void Update () {
	
		
	}
}
