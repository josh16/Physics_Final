using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour
{
    public Rigidbody rb;
   // public float platformMove;

    //Platform variables
   // public Transform startPos;
   // public Transform endPos;
   public float moveSpeed;

   // Transform platForm;



    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


   void OnCollisionEnter(Collision col)
    {

     if (col.gameObject.CompareTag("Player"))
        {
            rb.AddForce(Vector3.forward * moveSpeed );
            Debug.Log("On Platform!");
        }
    }
    




}
