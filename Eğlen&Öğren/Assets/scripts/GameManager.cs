using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject SecimEkrani;
    public void play()
    {
        Mainmenu.SetActive(false);
        SecimEkrani.SetActive(true);    
    }
    public void geri()
    {
        Mainmenu.SetActive(true);
        SecimEkrani.SetActive(false);
    }
    public void cikis()
    {
        Application.Quit();
    }
    public void hayvanbutonu()
    {
        SceneManager.LoadScene(1);
    }
    public void renkbutonu()
    {
        SceneManager.LoadScene(2);
    }
    public void sekilbutonu()
    {
        SceneManager.LoadScene(3);
    }
    private void Start() 
    {
        Mainmenu.SetActive(true);
        SecimEkrani.SetActive(false);
    }


}
