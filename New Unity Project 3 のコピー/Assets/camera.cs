using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	Vector3 Saveposition;
	public GameObject graphics;
	// Use this for initialization
	void Start () {
		Saveposition = transform.position;
	}

	float b = 0.0f;
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(graphics.transform.position.x+0.3f*Mathf.Sin (Time.frameCount * 0.0001f), Saveposition.y, graphics.transform.position.z+Saveposition.z);
//		a += 0.05f;
//		this.transform.position = new Vector3(a, Saveposition.y, Saveposition.z);

		Debug.Log (this.transform.position);
	}
}
