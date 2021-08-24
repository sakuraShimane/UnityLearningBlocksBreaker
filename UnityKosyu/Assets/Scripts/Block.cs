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

    private void OnCollisionEnter( Collision collision )//G‚ê‚½uŠÔ‚É
    {
        if ( !collision.gameObject.CompareTag("Ball") ) return;
        Destroy( this.gameObject );
    }

    private void OnCollisionStay( Collision collision )//G‚ê‚Ä‚¢‚éuŠÔ‚ÍÀs‚³‚ê‚é‚Ö‚±‚ñ‚Å‚¢‚é‚Æ‚«@‰½ŒÂ‚©‚È‚ª‚ê‚½‚è‚·‚é@‚ ‚Ü‚èg‚í‚È‚¢
    { 
    
    }

    private void OnCollisionExit( Collision collision )//—£‚ê‚Ä‚¢‚­‚Æ‚«
    {

    }

    //Collider ‚Ì@IsTriggerON‚É‚µ‚Ä‚é‚Æ‚Â‚©‚¦‚é
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
