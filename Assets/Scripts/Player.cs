using UnityEngine;
using UnityEngine.Assertions;
using System.Collections;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{

    public float m_speed;

    public Rigidbody m_rb;


    void Start()
    {
        m_rb = GetComponent<Rigidbody>();

    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_rb.AddForce(new Vector3(0.0f, 300.0f,0.0f));
        }
       

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);


        m_rb.AddForce(movement * m_speed);

    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("death"))
        {

            SceneManager.LoadScene("gameover");

        }



    }




}