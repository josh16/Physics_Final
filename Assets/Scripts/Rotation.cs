using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour 
{

	public float Rotationspeed;

	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(0, Rotationspeed,0);
	}
}
