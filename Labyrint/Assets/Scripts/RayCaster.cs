using UnityEngine;
using System.Collections;

public class RayCaster : MonoBehaviour {
	public Rigidbody rb;
	public float thrust;
	public LayerMask mask = -9;
	public float force;
		
	// Use this for initialization

	void Start () {
		rb = GetComponent<Rigidbody>();
	}	
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		float theDistance;

		if (Input.GetKey (KeyCode.E)){
		Vector3 forward = transform.TransformDirection (Vector3.forward) * 100;
		Debug.DrawRay (transform.position, forward, Color.red);

		if (Physics.Raycast (transform.position, (forward), out hit)){
			theDistance = hit.distance;
				if(hit.rigidbody)
				{
					hit.rigidbody.AddForceAtPosition(transform.forward * 10, hit.point);
				}
			}
			}
	}
}