using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour {

	public Transform player;

	void Start(){
	}
	// Update is called once per frame
	void Update () {
		
		transform.LookAt(player);
	}
}
