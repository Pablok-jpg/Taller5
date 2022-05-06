using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mexico_fogata : MonoBehaviour
{
    public int mexicoEsen;
    public int CentroEsen;
    public int SurEsen;
    public float tem = 1f;

    

    public void Awake()
    {
        
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "LetraM")
        {

           

        }

        if (collision.gameObject.tag == "VestuarioM")
        {
            

        }

        if (collision.gameObject.tag == "instruM")
        {
           
        }
    }
    

   

}
