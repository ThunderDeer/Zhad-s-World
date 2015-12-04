using UnityEngine;
using System.Collections;

public class WalkAnimationZhad : MonoBehaviour {

	public AnimationClip walkAnimation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			GetComponent<Animation>().Play ();
		}
		if (Input.GetKey(KeyCode.S)) {
			GetComponent<Animation>().Play ();
		}
		
//		if (Input.GetKeyUp(KeyCode.W)) {
//			GetComponent<Animation>().Stop ();
//		}
//		if (Input.GetKeyUp(KeyCode.S)) {
//			GetComponent<Animation>().Stop ();
//		}
	}
}
