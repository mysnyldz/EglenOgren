using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ilkMenu;
    public GameObject SecimEkrani;
    public void play()
    {
        ilkMenu.SetActive(false);
        SecimEkrani.SetActive(true);    
    }
    public void Geri()
    {
        ilkMenu.SetActive(true);
        SecimEkrani.SetActive(false);
    }
    public void Cikis()
    {
        Application.Quit();
    }
    public void HayvanButonu()
    {
        SceneManager.LoadScene(1);
    }
    public void RenkButonu()
    {
        SceneManager.LoadScene(2);
    }
    public void sekilbutonu()
    {
        SceneManager.LoadScene(3);
    }
    private void Start() 
    {
        ilkMenu.SetActive(true);
        SecimEkrani.SetActive(false);
    }


}
