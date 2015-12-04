using UnityEngine;
using System.Collections;

public class BuildObject : MonoBehaviour {
	
	public GameObject gatePrefab;
	public Transform player;
	public Vector3 spawnRotation = new Vector3(90,0,0);
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			Instantiate(gatePrefab, player.position, player.rotation);
		}
	}
}
