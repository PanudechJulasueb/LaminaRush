using UnityEngine;
using System.Collections;

public class Monstermove : MonoBehaviour {
	public float speed = 0.2f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.right*-speed*Time.deltaTime;
	}
}
