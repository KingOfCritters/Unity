using UnityEngine;
using System.Collections;

public class PickUpScript : MonoBehaviour {

    public Rigidbody move;
	public SphereCollider sphereCollider;

	private float speed = 1;

    void Start () {
		InvokeRepeating("Move", 0 , 1); // repeats the Move() method every 1 second, and starts at 0 seconds(as soon as script starts)
    }

	// Update is called once per frame
	void Update () {
		
	}

    void Move()
    {
		move.velocity = Random.insideUnitSphere * speed; // random direction.
    }

	void OnCollisionEnter (Collision collision) {
		Debug.Log ("hit");
		if (collision.gameObject.CompareTag ("weapon")) {
			collision.gameObject.transform.parent = transform;
			collision.gameObject.tag = "attatched"; 
			sphereCollider.radius += .08f;

			Debug.Log (collision.gameObject.tag);

			move.mass++; // make rigidbody heavier 
			speed++; // make it faster for the Move() method;

			//collision.gameObject.transform.localPosition = CheckRadius(collision); // attatches thing at checkradius() distance.


		
		}
	}


	Vector3 CheckRadius(Collision other)
	{
		return other.contacts [1].point;
	}
}
