using UnityEngine;
using System.Collections;
using System.Threading;
using System.Diagnostics;

public class eq : MonoBehaviour {
	Vector3 Saveposition;
	public GameObject graphics;
	float times;
	bool t = false;
	//Stopwatch s = new Stopwatch ();
	// Use this for initialization
	void Start () {
		Saveposition = transform.position;


	}
	void earth (){
		times = 10;

		//s.Start ();
		//Debug.Log("foo");
		//times = times - Time.deltaTime;
		t = true;
		//while (s.ElapsedMilliseconds < 5000) {

					//	transform.position = new Vector3 (transform.position.x + 0.003f * Mathf.Sin (Time.frameCount * 0.5f), Saveposition.y, transform.position.z + Saveposition.z);

		//}
	}
	


	float a = 0.0f;
	// Update is called once per frame
	void Update () {
		times = times - Time.deltaTime;
		if(t==true&&times<5&&times>0){
			transform.position = new Vector3 (transform.position.x + 0.01f * Mathf.Sin (Time.frameCount * 0.5f), Saveposition.y, transform.position.z + Saveposition.z);
		}
		//if(s.ElapsedMilliseconds >= 5000){
		//transform.position = new Vector3(transform.position.x+0.003f*Mathf.Sin (Time.frameCount * 0.5f), Saveposition.y, transform.position.z+Saveposition.z);
		
		//a += 0.05f;
//		this.transform.position = new Vector3(a, Saveposition.y, Saveposition.z);

		//Debug.Log (this.transform.position);
		
		}
	}

