using UnityEngine;
using System.Collections;

public class fooling : MonoBehaviour {
	public int foll_count;
	int num=0;
	public Vector3 force;
	public Vector3 forcePosition;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().useGravity = false;
	}
	void folls(){
		num++;
		Debug.Log (num);
				if (num == foll_count) {
						Debug.Log ("foo");
						GetComponent<Rigidbody>().useGravity = true;
						GetComponent<Rigidbody>().AddForceAtPosition(force,forcePosition,ForceMode.Impulse);
				}
		}
			
	
	// Update is called once per frame
	void Update () {
	
	}
}
