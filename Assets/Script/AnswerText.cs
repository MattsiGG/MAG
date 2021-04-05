using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerText : MonoBehaviour
{
    // Start is called before the first frame update
    public static int ans = 0;

    void Start()
    {
        ans = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0)){
            CalcAnswer(0);
        }else if(Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)){
            CalcAnswer(1);
        }else if(Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)){
            CalcAnswer(2);
        }else if(Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)){
            CalcAnswer(3);
        }else if(Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)){
            CalcAnswer(4);
        }else if(Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)){
            CalcAnswer(5);
        }else if(Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)){
            CalcAnswer(6);
        }else if(Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)){
            CalcAnswer(7);
        }else if(Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)){
            CalcAnswer(8);
        }else if(Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)){
            CalcAnswer(9);
        }else if(Input.GetKeyDown(KeyCode.Backspace)){
            CalcAnswer(-1);
        }
    }

    public void SetAnswerText(string ansText){
        GetComponent<Text>().text = ansText;
    }

    public void CalcAnswer(int k){
        if(k == -1){
            ans = ans / 10;
        }else{
            ans = ans * 10 + k;
        }
        if(ans > 10000){
            ans = 9999;
        }
        SetAnswerText(ans.ToString());
    }
}
