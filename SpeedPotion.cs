using UnityEngine;
using System.Collections;

public class SpeedPotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == "Player") {
			Player.speed+=0.5f;
			Debug.Log ("GetSpeed");
			Destroy(gameObject);
		} 

}
}
