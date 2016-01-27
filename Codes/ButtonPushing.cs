using UnityEngine;
using System.Collections;

public class ButtonPushing : MonoBehaviour
{
	
	public Light Light;
	public GameObject goLightSwitch;
	
	private bool _switchOn;
	void OnMouseDown()
	{
		if (_switchOn)
		{
			Light.enabled = false;				
		}
		
		
		else if (!_switchOn)
		{
			Light.enabled = true;
		}
		
	}
}