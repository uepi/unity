using UnityEngine;
using System.Collections;

public class foll_trans : MonoBehaviour {
	public float times;
	bool f = false ;
	public Vector3 force;
	public Vector3 forcePosition;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().useGravity = false;

	
	}
	
	// Update is called once per frame
	void Update () {
		times = times - Time.deltaTime;
		if (f == false && times < 0) {
			f = true;
			GetComponent<Rigidbody>().useGravity = true;
			GetComponent<Rigidbody>().AddForceAtPosition(force,forcePosition,ForceMode.Impulse);
				
		}

	
	}
}
