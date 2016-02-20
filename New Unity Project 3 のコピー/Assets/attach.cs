using UnityEngine;
using System.Collections;

public class attach : MonoBehaviour {
	public GUITexture Tgui;
	// Use this for initialization
	void Start () {

	
	}
	void OnControllerColliderHit(ControllerColliderHit hit){
				if (hit.gameObject.tag == "follobject") {
						Tgui.SendMessage ("dead");
				}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
