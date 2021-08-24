using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI�g���̂ɕK�v�H

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

        this.gameObject.GetComponent<Text>().text = currentTime.ToString();//Text�͕����񂾂���float->string�ɕϊ�
    }
}
