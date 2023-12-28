using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private bool eldevar;
    public GameObject image;
    public GameObject image2;
    public GameObject image3;
    public GameObject plastic_yesil;
    public GameObject metal_sarý;
    public GameObject kagit_mavi;

    public bool image_bool;
    public bool image_bool2;
    public bool image_bool3;
    public bool image_bool4;
    private void Awake()
    {
        eldevar = false;
        image_bool = false;
        image_bool2 = false;
        image_bool3 = false;
        image_bool4 = false;
    }

    public void plastic_var()
    {
        image.SetActive(true);
        image_bool=true;
    }

    public void plastic_var2()
    {
        if (image_bool)
        {
            image.SetActive(false);
            plastic_yesil.SetActive(true);
            StartCoroutine(MyEnumerator());
            image_bool=false;
        }
        
        
    }

    public void metal_var()
    {
        image2.SetActive(true);
        image_bool2 = true;
    }

    public void metal_var2()
    {
        if(image_bool2)
        {
            image2.SetActive(false);
            metal_sarý.SetActive(true);
            StartCoroutine(MyEnumerator());
            image_bool2=false;
        }
        

    }

    public void kagit_var()
    {
        image3.SetActive(true);
        image_bool3 = true;
    }

    public void kagit_var2()
    {
        if(image_bool3)
        {
            image3.SetActive(false);
            kagit_mavi.SetActive(true);
            StartCoroutine(MyEnumerator());
            image_bool3=false;
        }
        

    }

    IEnumerator MyEnumerator()
    {
        Debug.Log("Enumerator baþladý.");

        yield return new WaitForSeconds(4f); 
        Debug.Log("2 saniye bekledik.");
        plastic_yesil.SetActive(false);
        metal_sarý.SetActive(false);
        kagit_mavi.SetActive(false);
    }


}
