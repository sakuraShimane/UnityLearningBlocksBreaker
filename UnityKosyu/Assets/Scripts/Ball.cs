using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
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
        //0`90¨45@91`180¨135‚É‚·‚é@‚Í‚Ë‚©‚¦‚è‚ª360‚É‚¢‚Á‚¿‚á‚¤‚©‚ç
    }
}
