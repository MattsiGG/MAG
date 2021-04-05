using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float countTime = 10;
    GameObject gs;
    void Start(){
        gs = GameObject.Find("GameSystem");
        countTime = Setting.gameTime;
    }
    // Update is called once per frame
    void Update()
    {
        countTime -= Time.deltaTime;
        GetComponent<Text>().text = countTime.ToString("F2");
        if(countTime <= 0){
            gs.GetComponent<GameSystem>().GoResult();
        }
    }
}
