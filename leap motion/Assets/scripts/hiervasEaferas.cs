using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class hiervasEaferas : MonoBehaviour
{
    public float speed;
    public Transform posicion;

    Vector3 direccion;
    Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    private void Update()
    {
        direccion = ( posicion.position - transform.position ).normalized;

        
    }
    private void FixedUpdate()
    {
        

        if (rb.velocity.magnitude > 0.7f)
        {
            rb.velocity=Vector3.zero;
            rb.AddForce(direccion * speed*Time.fixedDeltaTime,ForceMode.VelocityChange);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        //print(collision.gameObject.name);
        if (collision.gameObject.tag == "fogata")
        {
            Destroy(gameObject);


        }

        
    }
    public void OnCollisionExit(Collision collision)
    {
        print(collision.gameObject.name);
    }

}

