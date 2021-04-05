using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetScore(){
        GetComponent<Text>().text = Judgment.Score.ToString();
    }
}
