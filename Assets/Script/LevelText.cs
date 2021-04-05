using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetLevel(){
        GetComponent<Text>().text = Setting.level;
    }
}
