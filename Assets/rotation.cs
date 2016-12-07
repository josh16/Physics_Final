using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour
{
    public float amount = 50f;
    public Rigidbody rigidbody;

    private float h,v;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //float  h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
        //float v// = Input.GetAxis("Vertical") * amount * Time.deltaTime;

        rigidbody.AddTorque(transform.up * h);
        rigidbody.AddTorque(transform.right * v);

    }
}
