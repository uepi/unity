using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	public GameObject camera;
	bool t = false;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.transform.tag == "Player") {
			camera.SendMessage ("SET");
			Debug.Log("ok");
			
		}
	}

	// Update is called once per frame
	void Update () {
		
		
	}
}