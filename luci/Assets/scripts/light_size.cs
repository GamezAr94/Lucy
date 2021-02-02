using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_size : MonoBehaviour {

	public Transform size;
	public float timeDecrease;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(size.transform.localScale.x>0 && size.transform.localScale.y >=0 ){
			size.localScale -= new Vector3(timeDecrease, timeDecrease,0)*Time.deltaTime;
			}else{
				Debug.Log("Muerto" + size.transform.localScale.x);
			}
		//Debug.Log(size.localScale);
	}
}
