using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleButtonSystem : MonoBehaviour
{
    GameObject LevelCanvas, TimeCanvas;
    // Start is called before the first frame update
    void Start()
    {
        LevelCanvas = GameObject.Find("LevelCanvas");
        TimeCanvas = GameObject.Find("TimeCanvas");
        LevelCanvas.SetActive(false);
        TimeCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLevelCanvas(int k){
        if(k == 0){
            LevelCanvas.SetActive(false);
        }else if(k == 1){
            LevelCanvas.SetActive(true);
        }
    }
    public void SetTimeCanvas(int k){
        if(k == 0){
            TimeCanvas.SetActive(false);
        }else if(k == 1){
            TimeCanvas.SetActive(true);
        }
    }
}
