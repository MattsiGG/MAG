using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiQuestion : MonoBehaviour
{
    // Start is called before the first frame update
    string level = "EASY";
    public static int n1=0, n2=0;
    void Start()
    {
        level = Setting.level;
        SetMultiQuestion(level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMultiQuestion(string l){    
        //m,nは0で〇, 1で1〇, 2で〇〇
        if(l == "EASY"){
            n1 = Random.Range(1, 10);
            n2 = Random.Range(1, 10);
        }else if(l == "NORMAL"){
            n1 = Random.Range(1, 10);
            n2 = Random.Range(10, 20);
        }else if(l == "HARD"){
            n1 = Random.Range(1, 10);
            n2 = Random.Range(20, 100);
        }else if(l == "EXPERT"){
            n1 = Random.Range(10, 20);
            n2 = Random.Range(20, 100);
        }else if(l == "MASTER"){
            n1 = Random.Range(20, 100);
            n2 = Random.Range(20, 100);
        }else if(l == "RANDOM"){
            n1 = Random.Range(1, 100);
            n2 = Random.Range(1, 100);
        }
        GetComponent<Text>().text = n1.ToString() + "×" + n2.ToString() + "=";
    }
}
