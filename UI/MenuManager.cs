using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
/*static List<string> sceneList = new List<string>();

<MenuManager>.sceneList.Add("1");

SceneManager.LoadScene(<MenuManager>.sceneList[<MenuManager.sceneList.Count -2], LoadSceneMode.Single);*/

    public void MoveToScene(int sceneID) {
        SceneManager.LoadScene(sceneID);
    }

    /*public void MoveBack(int sceneID) {

    }*/

    public void QuitGame() {
        Application.Quit();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene(0);
        }
    }
}
