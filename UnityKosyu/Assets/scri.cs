using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //���������R������
        rigidbody = gameObject.GetComponent<Rigidbody>();
        //double�ł��ŋ߂͌v�Z�����������ł���悤�ɂȂ��Ă����@float�ŏ����悤��߂��Ă���
        //�����ł�肽��������double
        rigidbody.velocity = new Vector3(4f,2f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}