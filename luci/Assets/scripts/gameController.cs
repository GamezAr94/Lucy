using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gameController : MonoBehaviour {

	public Transform mainCamera;
	public GameObject luces;
	public Vector3 spawnValues;
	public int lucesCount;
	public float spawnWait;
	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnWaves());
	}
	/*void FixedUpdate(){
		this.gameObject.transform.position += new Vector3(2,0,0)*Time.deltaTime;
	}*/
	// Update is called once per frame
	IEnumerator SpawnWaves () {
		for(int i=0; i<lucesCount; i++){
			Vector3 spawnPosition = new Vector3(mainCamera.transform.position.x + 10,Random.Range(-spawnValues.y, spawnValues.y),spawnValues.z);
			Instantiate(luces, spawnPosition, Quaternion.identity);
			yield return new WaitForSeconds(spawnWait);
		}
	}
}
