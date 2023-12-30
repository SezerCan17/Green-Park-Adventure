using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public AudioSource audioSource;
    private bool eldevar;
    public GameObject image;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject plastic_yesil;
    public GameObject plastic_yesil2;
    public GameObject plastic_yesil3;
    public GameObject metal_sarý;
    public GameObject metal_sarý2;
    public GameObject metal_sarý3;
    public GameObject kagit_mavi;
    public GameObject kagit_mavi2;
    public GameObject kagit_mavi3;
    public GameObject organic_kýrmýzý;
    public GameObject organic_kýrmýzý2;
    public GameObject organic_kýrmýzý3;

    

    public GameObject panel;
    

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

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    public void ResumeButton()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ExitButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitButton()
    {
        Application.Quit();
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
            plastic_yesil2.SetActive(true);
            plastic_yesil3.SetActive(true);
            audioSource.Play();
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
            metal_sarý2.SetActive(true);
            metal_sarý3.SetActive(true);
            audioSource.Play();
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
            kagit_mavi2.SetActive(true);
            kagit_mavi3.SetActive(true);
            audioSource.Play();
            StartCoroutine(MyEnumerator());
            image_bool3=false;
        }
        

    }

    public void organic_var()
    {
        image4.SetActive(true);
        image_bool4 = true;
    }

    public void organic_var2()
    {
        if (image_bool4)
        {
            image4.SetActive(false);
            organic_kýrmýzý.SetActive(true);
            organic_kýrmýzý2.SetActive(true);
            organic_kýrmýzý3.SetActive(true);
            audioSource.Play();
            StartCoroutine(MyEnumerator());
            image_bool4 = false;
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
        organic_kýrmýzý.SetActive(false);
        plastic_yesil2.SetActive(false);
        metal_sarý2.SetActive(false) ;
        kagit_mavi2.SetActive(false) ;
        organic_kýrmýzý2.SetActive(false ) ;
        plastic_yesil3.SetActive(false);
        metal_sarý3.SetActive(false);
        kagit_mavi3.SetActive(false);
        organic_kýrmýzý3.SetActive(false);
    }


}
