using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuV2 : MonoBehaviour
{

[SerializeField] private GameObject pauseMenuUI;
[SerializeField] private bool isPaused;
public AudioSource music;
public GM_GameMode GM;

private void Update()
{
    if(Input.GetKeyDown(KeyCode.Escape) && GM.gameOver == false)
    {
        isPaused = !isPaused;
        switchStates();
    }

    
}

void switchStates(){
    if(isPaused && GM.gameOver == false)
    {
        ActivateMenu();
    }

    else
    {
        DeactivateMenu();
    }
}

void ActivateMenu()
{
    Time.timeScale = 0;

    AudioSource[] audios = FindObjectsOfType<AudioSource>();

    foreach (AudioSource a in audios){
        a.Pause();
    }
    music.Play();

    pauseMenuUI.SetActive(true);
    isPaused = true;
}

public void DeactivateMenu()
{

    Time.timeScale = 1;

    AudioSource[] audios = FindObjectsOfType<AudioSource>();

    foreach (AudioSource a in audios){
        a.Play();
    }

    pauseMenuUI.SetActive(false);
    isPaused = false;
}

public void ToMenuGame()
 {
     DeactivateMenu();
     SceneManager.LoadSceneAsync(0);
 }

 public void QuitGame ()
 {
     Debug.Log("QUIT!");
     Application.Quit();
 }


}
