using UnityEngine;
using System.Collections;

public class Spawnmonster : MonoBehaviour {
	public float count=0;
	public float ranmon=0;
	public float countmon=0;
	public Transform Monster1;
	public Transform Monster2;
	public Transform Monster3;
	public float delay = 0;
	// Use this for initialization
	void Start () {
		count = 0;
		countmon = 0;
		delay = 0;
	}
	
	// Update is called once per frame
	void Update () {


		if (Player.pause == false) {
				
						if (delay == 0) {
							delay+=7;
								if (countmon < 3) {
										count = Random.Range (0, 150);
										ranmon = Random.Range (0, 3);
										if (count == 0) {
												if (ranmon == 0) {
											
														Transform spawnMon = (Transform)Instantiate (Monster1, transform.position, transform.rotation);
														spawnMon.name = "Monster1";
														spawnMon.gameObject.AddComponent<Monstermove> ();
							
												}
												if (ranmon == 1) {
												
														Transform spawnMon = (Transform)Instantiate (Monster2, transform.position, transform.rotation);
														spawnMon.name = "Monster2";
														spawnMon.gameObject.AddComponent<Monstermove> ();

												}
												if (ranmon == 2) {
		
														Transform spawnMon = (Transform)Instantiate (Monster3, transform.position, transform.rotation);
														spawnMon.name = "Monster3";
														spawnMon.gameObject.AddComponent<Monstermove> ();
		
												}
												count += 1;
												countmon += 1;

										}
								}
			}

			if(delay<0){
				delay=0;
			}
			delay-=1;

				}
		}
}
