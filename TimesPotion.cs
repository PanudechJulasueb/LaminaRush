using UnityEngine;
using System.Collections;

public class TimesPotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == "Player") {
			Times.timeleft+=1;
			Debug.Log ("GetTimes");
			Destroy(gameObject);
		} 

}
}
