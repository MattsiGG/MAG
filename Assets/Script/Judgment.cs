using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judgment : MonoBehaviour
{
    public static int Score = 0;
    GameObject hantei_maru, hantei_batsu;
    MultiQuestion MQ;
    AnswerText AT;
    // Start is called before the first frame update
    void Start(){
        Score = 0;
        hantei_maru = GameObject.Find("hantei_maru");
        hantei_batsu = GameObject.Find("hantei_batsu");
        hantei_maru.SetActive(false);
        hantei_batsu.SetActive(false);
        MQ = GameObject.Find("QuizText").GetComponent<MultiQuestion>();
        AT = GameObject.Find("AnswerText").GetComponent<AnswerText>();
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return)){
            Judg();
        }
    }
    public void Judg(){
        if(MultiQuestion.n1 * MultiQuestion.n2 == AnswerText.ans){
            StartCoroutine("Hantei_Maru");
            Score += 1;
        }else{
            StartCoroutine("Hantei_Batsu");
        }
        MQ.SetMultiQuestion(Setting.level);
        AnswerText.ans = 0;
        AT.SetAnswerText("0");
    }
    IEnumerator Hantei_Maru(){
        hantei_maru.SetActive(true);
        yield return new WaitForSeconds(0.2f); //0.2s停止
        hantei_maru.SetActive(false);
    }
    IEnumerator Hantei_Batsu(){
        hantei_batsu.SetActive(true);
        yield return new WaitForSeconds(0.2f); //0.2s停止
        hantei_batsu.SetActive(false);
    }
}
