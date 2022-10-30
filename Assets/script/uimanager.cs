using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uimanager : MonoBehaviour
{

    public GameObject clicktomutebtn;
    public GameObject mainmenupannel;
    public GameObject settingpannel;
    public GameObject howtoplaypannel;
    public GameObject creditpannel;
    public GameObject loadsplashpannel;
    public GameObject seasonpannel;
    public AudioSource btnaudio;




    void Start()
    {
        mainmenupannel.SetActive(true);
        settingpannel.SetActive(false);
        howtoplaypannel.SetActive(false);
        creditpannel.SetActive(false);
        loadsplashpannel.SetActive(false);
        seasonpannel.SetActive(false);
    }



    public void startbtnclicked()
    {
        mainmenupannel.SetActive(false);
        loadsplashpannel.SetActive(true);
        Invoke("loadscene", 6f);
        btnaudio.Play();
    }
    public void loadscene()
    {
        SceneManager.LoadScene(1);
    }
    public void season1btnclicked()
    {
        SceneManager.LoadScene(1);
        btnaudio.Play();
    }




    public void settingbtnclicked()
    {
        mainmenupannel.SetActive(false);
        settingpannel.SetActive(true);
        btnaudio.Play();
    }



    public void howtoplaybtnclicked()
    {
        mainmenupannel.SetActive(false);
        howtoplaypannel.SetActive(true);
        btnaudio.Play();
    }


    public void creditbtnclicked()
    {
        mainmenupannel.SetActive(false);
        creditpannel.SetActive(true);
        btnaudio.Play();
    }



    public void exitbtnclicked()
    {
        Application.Quit();
        btnaudio.Play();
    }

    public void crossbtnclicked()
    {
        mainmenupannel.SetActive(true);
        settingpannel.SetActive(false);
        howtoplaypannel.SetActive(false);
        creditpannel.SetActive(false);
        loadsplashpannel.SetActive(false);
        seasonpannel.SetActive(false);
        btnaudio.Play();
    }
}





