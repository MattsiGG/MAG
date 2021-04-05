using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public void StartGame(){
        SceneManager.LoadScene("Game");
    }
    public void BuckTitle(){
        SceneManager.LoadScene("Title");
    }

    public void GoResult(){
        SceneManager.LoadScene("Result");
    }
}
