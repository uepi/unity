using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class follcontler : MonoBehaviour {
	Stopwatch sw = new Stopwatch ();
	public float times;
	public GameObject ground;

	int num;

	// Use this for initialization

	void Start () {
		sw.Start ();
		num = 0;

	
	}
	
	// Update is called once per frame
	void Update () {
		times = times - Time.deltaTime;
		if (times < 0) {
			num++;
			ground.SendMessage ("earth");
			BroadcastMessage ("folls");
			times = 10;
		}
	}
}
