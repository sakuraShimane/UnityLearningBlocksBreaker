using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter( Collision collision )//�G�ꂽ�u�Ԃ�
    {
        if ( !collision.gameObject.CompareTag("Ball") ) return;
        Destroy( this.gameObject );
    }

    private void OnCollisionStay( Collision collision )//�G��Ă���u�Ԃ͎��s�����ւ���ł���Ƃ��@�����Ȃ��ꂽ�肷��@���܂�g��Ȃ�
    { 
    
    }

    private void OnCollisionExit( Collision collision )//����Ă����Ƃ�
    {

    }

    //Collider �́@IsTriggerON�ɂ��Ă�Ƃ�����
    private void OnTriggerEnter( Collider other )
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerStay( Collider other )
    {

    }

    private void OnTriggerExit( Collider other )
    {

    }
}
