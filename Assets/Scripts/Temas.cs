using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temas : MonoBehaviour
{
    private bool icerde;
    public Animator animator;
    private GameObject temasEdilenObj;

    private void Awake()
    {
        
        icerde = false;
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag=="Plastic")
    //    {

    //        collision.gameObject.SetActive(false);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Plastic")
        {
            temasEdilenObj = other.gameObject;
            Debug.Log("icerde");
            icerde =true;
            
                //other.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag=="Plastic")
        {
            Debug.Log("Dýsarda");
            icerde =false;
            
        }
    }

    private void Update()
    {
        if(icerde && Input.GetKeyDown(KeyCode.E))
        {
            SilObjeyi();
        }
    }

    void SilObjeyi()
    {
        temasEdilenObj.SetActive(false);
        animator.SetTrigger("collect");
    }
}
