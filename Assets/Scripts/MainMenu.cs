using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [FMODUnity.EventRef] [SerializeField] private string selectEvent_ = "";
    
    //The functions below are public so we can access them from the OnClick() function of the buttons.
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlaySound()
    {
        FMODUnity.RuntimeManager.PlayOneShot(selectEvent_);
    }
}
