using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject HPSlider;

    // Start is called before the first frame update
    void Start()
    {
        HPSlider = GameObject.FindGameObjectWithTag("HPSlider");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit( Collision collision )
    {
        if ( !collision.gameObject.CompareTag("Ball")) return;
        HPSlider.GetComponent<HPSlider>().Damaged();
    }
}
