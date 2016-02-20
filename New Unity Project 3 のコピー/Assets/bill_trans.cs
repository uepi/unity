using UnityEngine;
using System.Collections;

public class bill_trans : MonoBehaviour {
	public int t_num;
	int b =0;
	Vector3 Saverotation;
	// Use this for initialization
	void Start () {
		Saverotation = transform.rotation.eulerAngles;
	}
	void b_trans(){
		b++;
		if (t_num == b) {
			Vector3 euler = new Vector3(Saverotation.x, Saverotation.y,Saverotation.z);
			transform.rotation = Quaternion.Euler(euler);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
}
