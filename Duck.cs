using UnityEngine;
using System.Collections;

public class Duck : MonoBehaviour {
	public float delay=0;
	public Transform MagicPrefab;
	// Use this for initialization
	void Start () {
		delay = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Player.pause == false) {
			if (delay == 0) {
				Transform spawnBullet = (Transform)Instantiate (MagicPrefab, transform.position, transform.rotation);
				spawnBullet.name = "Fireball";
				spawnBullet.gameObject.AddComponent<MagicMove> ();
				delay=60;
			}
		}
		if (delay > 0) {
			delay-=1;
		}
		
	}
}
