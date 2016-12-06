using UnityEngine;
using System.Collections;

public class Ramp : MonoBehaviour
{

	void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.rigidbody.AddForce(new Vector3(1200.0f, 700.0f, 0.0f));
        }
    }



}
