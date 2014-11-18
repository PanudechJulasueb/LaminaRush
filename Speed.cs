using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour {
	private float acceleration=0.05f;
	public static float speed = 0.001f;
	public static bool pause = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		speed += acceleration / 10;
		guiText.text = speed.ToString("F1")+" km/hr";
		if (Input.GetKeyDown ("p")) {
			pausemenu ();
		} else {
			
		}

	}

	void pausemenu(){
		if(pause==false)
		{
			Debug.Log ("Pause");
			acceleration=0;
			pause=true;
		}
		else if(pause==true)
		{
			Debug.Log ("UnPause");
			acceleration+=0.005f;
			pause=false;
		}
	}
	
}
