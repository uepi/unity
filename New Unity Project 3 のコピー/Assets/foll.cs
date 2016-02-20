using UnityEngine;
using System.Collections;

public class foll : MonoBehaviour {
	public GameObject follObject;
	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider collider){
				if (collider.gameObject.transform.tag == "Player") {
						follObject.SendMessage ("foll");
			Debug.Log ("foooo");
				}
		}
	
	// Update is called once per frame
	void Update () {

	
	}
}
