using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
 public void PlayGame(int i)
 {
     SceneManager.LoadSceneAsync(i);
 }

 public void QuitGame ()
 {
     Debug.Log("QUIT!");
     Application.Quit();
 }
}
