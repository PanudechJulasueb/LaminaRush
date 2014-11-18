using UnityEngine;
using System.Collections;

public class Rabbit : MonoBehaviour {
	public float delay=0;
	public Transform ArrowPrefab;
	// Use this for initialization
	void Start () {
		delay = 0;
	}
	
	// Update is called once per frame
	void Update () {

						if (Player.pause == false) {
			if (delay == 0) {
								Transform spawnBullet = (Transform)Instantiate (ArrowPrefab, transform.position, transform.rotation);
								spawnBullet.name = "Arrow";
								spawnBullet.gameObject.AddComponent<ArrowMove> ();
				delay=60;
			}
		}
		if (delay > 0) {
			delay-=1;
				}

	}
}
