using UnityEngine;
using System.Collections;

public class Times : MonoBehaviour {
	public static float timeleft = 60.0f;
	// Use this for initialization
	void Start () {
		timeleft=60.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timeleft -= Time.deltaTime;
	guiText.text = timeleft.ToString("F1");
		if (timeleft < 0) {
			renderer.enabled=false;	
		}
	}
}
