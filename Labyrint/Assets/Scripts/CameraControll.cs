using UnityEngine;
using System.Collections;

public class CameraControll : MonoBehaviour {

	public float PlayerSpeed = 5.0f;

	//void start = first frame what to do
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		//movement
		transform.Translate (Vector3.up * Input.GetAxis("Mouse Y") * PlayerSpeed * Time.deltaTime);//0.0.1
		transform.Translate (Vector3.right * Input.GetAxis("Mouse X") * PlayerSpeed * Time.deltaTime);//0.0.1
	}
}