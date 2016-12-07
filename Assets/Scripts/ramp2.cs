using UnityEngine;
using System.Collections;

public class ramp2 : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.rigidbody.AddForce(new Vector3(-1500.0f, 400.0f, 0.0f));
        }
    }

}
