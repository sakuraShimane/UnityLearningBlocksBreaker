using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //書き方が３個かある
        rigidbody = gameObject.GetComponent<Rigidbody>();
        //doubleでも最近は計算処理が早くできるようになってきた　floatで書くよう定められている
        //高速でやりたい処理はdouble
        rigidbody.velocity = new Vector3(4f,2f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
