using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float acceleration=0.05f;
	public static float speed = 0.001f;
	public static float distanceTraveled;
	
	public static bool pause = false;
	
	// Use this for initialization
	void Start () {
		speed = 0;
	}

	// Update is called once per frame
	void Update () {
		speed += acceleration / 10;
		transform.position = transform.position + Vector3.right * speed * Time.deltaTime;
		distanceTraveled = transform.localPosition.x;

		if (Input.GetKeyDown ("p")) {
						pausemenu ();
				} else {

		}

		}
	void pausemenu(){
		if(pause==false)
		{
			Debug.Log ("Pause");
			Time.timeScale=0.0f;
			pause=true;
		}
		else if(pause==true)
		{
			Debug.Log ("UnPause");
			Time.timeScale=1.0f;
			pause=false;
		}
	}


			

	}
				