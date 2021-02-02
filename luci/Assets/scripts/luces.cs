using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luces : MonoBehaviour {

	public GameObject luzBack;
	public float incLight;
	// Use this for initialization
	void Start () {
		luzBack = GameObject.FindGameObjectWithTag("luzBack");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
			Debug.Log("LUZ!!");
			Destroy(this.gameObject);
			luzBack.transform.localScale+=new Vector3(incLight,incLight,0);
		}
	}
	
}
