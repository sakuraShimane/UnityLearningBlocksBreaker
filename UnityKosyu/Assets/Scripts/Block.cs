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

    private void OnCollisionEnter( Collision collision )//触れた瞬間に
    {
        if ( !collision.gameObject.CompareTag("Ball") ) return;
        Destroy( this.gameObject );
    }

    private void OnCollisionStay( Collision collision )//触れている瞬間は実行されるへこんでいるとき　何個かながれたりする　あまり使わない
    { 
    
    }

    private void OnCollisionExit( Collision collision )//離れていくとき
    {

    }

    //Collider の　IsTriggerONにしてるとつかえる
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
