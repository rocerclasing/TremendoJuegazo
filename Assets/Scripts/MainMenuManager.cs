using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

    public int levelToLoad;

    public void NewGameButton()
   {
        SceneManager.LoadScene(levelToLoad);
    }
}
