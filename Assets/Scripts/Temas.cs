using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temas : MonoBehaviour
{
    private bool icerde;
    public Animator animator;
    private GameObject temasEdilenObj;
    public UIManager uiManager;
    public bool eldevar;
    public bool eldevar2;
    public bool eldevar3;
    public bool eldevar4;
    public bool eldevarGenel;

    private void Awake()
    {
        eldevar = false;
        icerde = false;
        eldevar2 = false;
        eldevar3 = false;
        eldevar4 = false;
        eldevarGenel = false;
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

        if (other.gameObject.tag == "organic")
        {
            temasEdilenObj = other.gameObject;
            Debug.Log("icerde");
            icerde = true;

        }
        if (other.gameObject.tag == "OrganicBin")
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

        if (other.gameObject.tag == "organic")
        {
            Debug.Log("Dýsarda");
            icerde = false;

        }
        if (other.gameObject.tag == "OrganicBin")
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
                if(eldevar)
                {
                    Plastic_yok();
                }
                
            }
            if (temasEdilenObj.tag == "metal")
            {
                SilObjeyi2();
            }
            if (temasEdilenObj.tag == "MetalBin")
            {
                if (eldevar2)
                {
                    metal_yok();
                }
                
            }
            if (temasEdilenObj.tag == "kagit")
            {
                SilObjeyi3();
            }
            if (temasEdilenObj.tag == "PaperBin")
            {
                if (eldevar3)
                {
                    kagit_yok();
                }
                
            }

            if (temasEdilenObj.tag == "organic")
            {
                SilObjeyi4();
            }
            if (temasEdilenObj.tag == "OrganicBin")
            {
                if (eldevar4)
                {
                    organic_yok();
                }

            }

        }
    }

    void SilObjeyi()
    {
        if(!eldevar && !eldevarGenel)
        {
            Plastic_var();
            temasEdilenObj.SetActive(false);
            animator.SetTrigger("collect");
        }
        
    }

    public void Plastic_var()
    {
        uiManager.plastic_var();
        eldevar = true;
        eldevarGenel = true;
    }

    public void Plastic_yok()
    {
        uiManager.plastic_var2();
        eldevar=false;
        eldevarGenel=false;
    }


    void SilObjeyi2()
    {
        if(!eldevar2 && !eldevarGenel)
        {
            metal_var();
            temasEdilenObj.SetActive(false);
            animator.SetTrigger("collect");
        }
        
    }

    public void metal_var()
    {
        uiManager.metal_var();
        eldevar2 = true;
        eldevarGenel = true;
    }

    public void metal_yok()
    {
        uiManager.metal_var2();
        eldevar2 = false;
        eldevarGenel = false;
    }

    void SilObjeyi3()
    {
        if(!eldevar3 && !eldevarGenel)
        {
            kagit_var();
            temasEdilenObj.SetActive(false);
            animator.SetTrigger("collect");
        }
        
    }

    public void kagit_var()
    {
        uiManager.kagit_var();
        eldevar3 = true;
        eldevarGenel = true;
    }

    public void kagit_yok()
    {
        uiManager.kagit_var2();
        eldevar3 = false;
        eldevarGenel = false;
    }

    void SilObjeyi4()
    {
        if (!eldevar3 && !eldevarGenel)
        {
            organic_var();
            temasEdilenObj.SetActive(false);
            animator.SetTrigger("collect");
        }

    }

    public void organic_var()
    {
        uiManager.organic_var();
        eldevar4 = true;
        eldevarGenel = true;
    }

    public void organic_yok()
    {
        uiManager.organic_var2();
        eldevar4 = false;
        eldevarGenel = false;
    }
}
