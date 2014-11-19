using UnityEngine;
using System.Collections;

public class Anime : MonoBehaviour {
	public  Animator anim;
	public static bool wolfrun=false;
	public static bool wolfattack=false;
	// Use this for initialization
	void Start () {
		anim.GetComponent("Animator");
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("wolf_run", wolfattack);
		anim.SetBool("wolf_att",wolfrun);
	}
}
