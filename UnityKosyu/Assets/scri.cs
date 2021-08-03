using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //‘‚«•û‚ª‚RŒÂ‚©‚ ‚é
        rigidbody = gameObject.GetComponent<Rigidbody>();
        //double‚Å‚àÅ‹ß‚ÍŒvZˆ—‚ª‘‚­‚Å‚«‚é‚æ‚¤‚É‚È‚Á‚Ä‚«‚½@float‚Å‘‚­‚æ‚¤’è‚ß‚ç‚ê‚Ä‚¢‚é
        //‚‘¬‚Å‚â‚è‚½‚¢ˆ—‚Ídouble
        rigidbody.velocity = new Vector3(4f,2f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
