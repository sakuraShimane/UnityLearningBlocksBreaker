using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public float speed; //Unityでpublic表記すると、Inspectorで値をいじれる

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f; //fつけとこう
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKey( KeyCode.RightArrow ) )
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if( Input.GetKey( KeyCode.LeftArrow) )
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

    }
}
