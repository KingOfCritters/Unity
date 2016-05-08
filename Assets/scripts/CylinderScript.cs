using UnityEngine;
using System.Collections;

public class CylinderScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (tag.Equals ("attatched")) {
			Pulse ();
		}
	}

	void Pulse(){
		transform.localScale = new Vector3 (0.5f,2+Mathf.Sin(Time.time*10)/2,0.5f);


	}

}
