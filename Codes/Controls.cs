using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	public float PlayerSpeed = 5.0f;

	//void start = first frame what to do
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		//movement
		transform.Translate (Vector3.up * Input.GetAxis ("Jump") * PlayerSpeed * Time.deltaTime);
		transform.Translate (Vector3.forward * Input.GetAxis("Vertical") * PlayerSpeed * Time.deltaTime);//0.0.1
		}
	}