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
    public GameObject metal_sar�;
    public GameObject kagit_mavi;
    private void Awake()
    {
        eldevar = false;
    }

    public void plastic_var()
    {
        image.SetActive(true);
    }

    public void plastic_var2()
    {
        image.SetActive(false);
        plastic_yesil.SetActive(true);
        StartCoroutine(MyEnumerator());
        
    }

    public void metal_var()
    {
        image2.SetActive(true);
    }

    public void metal_var2()
    {
        image2.SetActive(false);
        metal_sar�.SetActive(true);
        StartCoroutine(MyEnumerator());

    }

    public void kagit_var()
    {
        image3.SetActive(true);
    }

    public void kagit_var2()
    {
        image3.SetActive(false);
        kagit_mavi.SetActive(true);
        StartCoroutine(MyEnumerator());

    }

    IEnumerator MyEnumerator()
    {
        Debug.Log("Enumerator ba�lad�.");

        yield return new WaitForSeconds(4f); 
        Debug.Log("2 saniye bekledik.");
        plastic_yesil.SetActive(false);
        metal_sar�.SetActive(false);
        kagit_mavi.SetActive(false);
    }


}
