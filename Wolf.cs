using UnityEngine;
using System.Collections;

public class Wolf : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay (Collider other)
	{
		if (other.gameObject.name == "Monster1" || other.gameObject.name == "Monster2") {
			Debug.Log ("Hit");
		} else if (other.gameObject.name == "Monster3") {
			

			Debug.Log ("Hit");
		}

	}
}
