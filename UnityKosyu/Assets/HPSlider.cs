using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Slider�̒l���Ƃ��Ă���

public class HPSlider : MonoBehaviour
{
    public float MaxHP;
    public float CurrentHP;

    // Start is called before the first frame update
    void Start()
    {
        //WallBottom = GameObject.FindObjectWithTag("WallBottom");
        CurrentHP = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Slider>().value = CurrentHP / MaxHP;
    }

    public void Damaged()
    {
        CurrentHP -= 10;
    }


}
