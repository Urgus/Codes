using UnityEngine;
using System.Collections;

public class OrbitCamera : MonoBehaviour 
{

	public GameObject target = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (target != null) 
		{
			transform.LookAt(target.transform);
		}
	}
}
