using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuV2 : MonoBehaviour
{

[SerializeField] private GameObject pauseMenuUI;
[SerializeField] private bool isPaused;

private void Update()
{
    if(Input.GetKeyDown(KeyCode.Escape))
    {
        isPaused = !isPaused;

    }

    if(isPaused)
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
    AudioListener.pause = true;
    pauseMenuUI.SetActive(true);
}

public void DeactivateMenu()
{
    Time.timeScale = 1;
    AudioListener.pause = false;
    pauseMenuUI.SetActive(false);
    isPaused = false;
}

public void ToMenuGame()
 {
     SceneManager.LoadScene(0);
 }

 public void QuitGame ()
 {
     Debug.Log("QUIT!");
     Application.Quit();
 }


}
