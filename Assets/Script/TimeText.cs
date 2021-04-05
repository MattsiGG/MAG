using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetTime();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetTime(){
        GetComponent<Text>().text = Setting.gameTime.ToString();
    }
}
