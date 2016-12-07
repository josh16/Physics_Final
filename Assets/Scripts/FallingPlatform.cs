using UnityEngine;
using System.Collections;

public class FallingPlatform : MonoBehaviour
{
    private GameObject other;

    void OnCollisionEnter(Collision col)
    {
        

        if (col.gameObject.CompareTag("Platform"))
        { 
            this.other = col.gameObject;
            StartCoroutine(FallingObject());
        }
    }

    IEnumerator FallingObject()
    {
        yield return new WaitForSeconds(0.75f);
        this.other.GetComponent<Rigidbody>().isKinematic = false;
        this.other.GetComponent<Rigidbody>().useGravity = true;
    }


}
