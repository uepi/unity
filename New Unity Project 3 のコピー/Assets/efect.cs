using UnityEngine;
using System.Collections;

public class efect : MonoBehaviour {
//	public Texture background;
	private Texture background;
	bool judge;
	// Use this for initialization
	void Start () {
		judge = false;
		background = GetComponent<GUITexture> ().texture;
	}
	void OnGUI(){
		if(judge ==true )
		GUI.DrawTexture (new Rect (Screen.width / 2 - 524, Screen.height / 2 - 254, background.width, background.height), background);
	}
	void dead(){
				judge = true;
		}		
	// Update is called once per frame
	void Update () {
	}
}
