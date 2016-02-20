using UnityEngine;
using System.Collections;

public class efe : VRGUI {
	bool t=false;
	//public Texture texture;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void SET(){
				t = true;
		Debug.Log ("set");
	}
	public override void OnVRGUI(){
			
			
				if (t == true) {
				//this.OnGUI();
				Debug.Log("catch");
				GUILayout.BeginArea(new Rect(0f,0f,Screen.width,Screen.height));
						//GUI.TextField (new Rect (20, 20, 20, 20), "Goal");	
				}
						//GUI.DrawTexture( new Rect(0,0,256,256),texture);
				
		}
	void OnGUI(){
				GUI.TextField (new Rect (20, 20, 20, 20), "Goal");	
		}
			
}
