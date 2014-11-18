using UnityEngine;
using System.Collections;

public class Att : MonoBehaviour {
	public Transform item;
	public Transform item2;
	public float count=0;
	public float count2=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerStay (Collider other)
	{
		
		if (other.gameObject.name == "Player") {
			Times.timeleft-=0.5f;
			Debug.Log("Hit");
			
			count = Random.Range (0, 5);
			if (count == 0){
				count2 = Random.Range (0,2);
				if(count2==0){
					Instantiate(item, transform.position, Quaternion.identity);
				}
				else if(count2==1){
					Instantiate (item2,transform.position, Quaternion.identity);
				}
				
				
			}else{
				Destroy(gameObject,0f);
			}
		}
	}
}



