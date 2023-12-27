using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temas : MonoBehaviour
{
    private bool icerde;
    public Animator animator;
    private GameObject temasEdilenObj;
    public UIManager uiManager;
    private bool eldevar;

    private void Awake()
    {
        
        icerde = false;
    }
   

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Plastic")
        {
            temasEdilenObj = other.gameObject;
            Debug.Log("icerde");
            icerde =true;
            
        }
        if(other.gameObject.tag=="PlasticBin")
        {
            temasEdilenObj = other.gameObject;
            Debug.Log("icerde");
            icerde = true;
        }

        if (other.gameObject.tag == "metal")
        {
            temasEdilenObj = other.gameObject;
            Debug.Log("icerde");
            icerde = true;

        }
        if (other.gameObject.tag == "MetalBin")
        {
            temasEdilenObj = other.gameObject;
            Debug.Log("icerde");
            icerde = true;
        }
        if (other.gameObject.tag == "kagit")
        {
            temasEdilenObj = other.gameObject;
            Debug.Log("icerde");
            icerde = true;

        }
        if (other.gameObject.tag == "PaperBin")
        {
            temasEdilenObj = other.gameObject;
            Debug.Log("icerde");
            icerde = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag=="Plastic")
        {
            Debug.Log("Dýsarda");
            icerde =false;
            
        }
        if(other.gameObject.tag=="PlasticBin")
        {
            icerde=false;
        }
        if (other.gameObject.tag == "metal")
        {
            Debug.Log("Dýsarda");
            icerde = false;

        }
        if (other.gameObject.tag == "MetalBin")
        {
            icerde = false;
        }
        if (other.gameObject.tag == "kagit")
        {
            Debug.Log("Dýsarda");
            icerde = false;

        }
        if (other.gameObject.tag == "PaperBin")
        {
            icerde = false;
        }
    }

    private void Update()
    {
        if(icerde && Input.GetKeyDown(KeyCode.E))
        {
            if(temasEdilenObj.tag=="Plastic")
            {
                SilObjeyi();
            }
            if(temasEdilenObj.tag=="PlasticBin")
            {
                Plastic_yok();
            }
            if (temasEdilenObj.tag == "metal")
            {
                SilObjeyi2();
            }
            if (temasEdilenObj.tag == "MetalBin")
            {
                metal_yok();
            }
            if (temasEdilenObj.tag == "kagit")
            {
                SilObjeyi3();
            }
            if (temasEdilenObj.tag == "PaperBin")
            {
                kagit_yok();
            }

        }
    }

    void SilObjeyi()
    {
        Plastic_var();
        temasEdilenObj.SetActive(false);
        animator.SetTrigger("collect");
    }

    public void Plastic_var()
    {
        uiManager.plastic_var();
        eldevar = true;
    }

    public void Plastic_yok()
    {
        uiManager.plastic_var2();
        eldevar=false;
    }


    void SilObjeyi2()
    {
        metal_var();
        temasEdilenObj.SetActive(false);
        animator.SetTrigger("collect");
    }

    public void metal_var()
    {
        uiManager.metal_var();
        eldevar = true;
    }

    public void metal_yok()
    {
        uiManager.metal_var2();
        eldevar = false;
    }

    void SilObjeyi3()
    {
        kagit_var();
        temasEdilenObj.SetActive(false);
        animator.SetTrigger("collect");
    }

    public void kagit_var()
    {
        uiManager.kagit_var();
        eldevar = true;
    }

    public void kagit_yok()
    {
        uiManager.kagit_var2();
        eldevar = false;
    }
}
