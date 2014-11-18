using UnityEngine;
using System.Collections;

public class MagicMove : MonoBehaviour {
	public float speed = 20f;
	public float acceleration=0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Player.pause == false) {
			speed += acceleration;
			transform.position += transform.right * speed * Time.deltaTime;
		}
	}
}
