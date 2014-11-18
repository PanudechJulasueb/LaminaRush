using UnityEngine;
using System.Collections;

public class Anime : MonoBehaviour {
	public  Animator anim;
	public static bool checkrun=false;
	public static bool checkattack=false;
	// Use this for initialization
	void Start () {
		anim.GetComponent("Animator");
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("run", checkattack);
		anim.SetBool("attack",checkrun);
	}
}
