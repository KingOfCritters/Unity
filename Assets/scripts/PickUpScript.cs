using UnityEngine;
using System.Collections;

public class PickUpScript : MonoBehaviour {

    public Rigidbody move;

    void Start () {
		InvokeRepeating("Move", Random.Range(0,5) , 1);
    }

	// Update is called once per frame
	void Update () {
		
	}

    void Move()
    {
		move.velocity = Random.insideUnitSphere * 5;
    }

	void OnCollisionEnter (Collision other) {
		Debug.Log ("hit");
		if (other.gameObject.CompareTag ("weapon")) {
			other.gameObject.transform.parent = transform;
			other.gameObject.tag = "attatched";
			other.gameObject.transform.localPosition = new Vector3 (0, 0, 0);
			//gameObject.GetComponent<Collider> ().bounds.Expand (1);
			Debug.Log (other.gameObject.tag);

		
		}
	}
}
