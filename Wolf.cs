using UnityEngine;
using System.Collections;

public class Wolf : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Anime.wolfrun = true;
		Anime.wolfattack = false;
	}
	
	// Update is called once per frame
	void Update () {
		Anime.wolfrun = true;
		Anime.wolfattack = false;
	}

	void OnTriggerStay (Collider other)
	{
		if (other.gameObject.name == "Monster1" || other.gameObject.name == "Monster2") {
			Anime.wolfrun = false;
			Anime.wolfattack = true;
			Debug.Log ("Hit");
		} else if (other.gameObject.name == "Monster3") {
			
			Anime.wolfrun = false;
			Anime.wolfattack = true;
			Debug.Log ("Hit");
		}

	}
}
