using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うのに必要？

public class Timer : MonoBehaviour
{
    public float limitTime;
    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = limitTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        this.gameObject.GetComponent<Text>().text = currentTime.ToString();//Textは文字列だからfloat->stringに変換
    }
}
