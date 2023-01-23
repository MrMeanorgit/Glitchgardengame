using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamehealth : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider myhealthbar;
    void Start()
    {
        myhealthbar.value = 100;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D othercollision)
    {
        decresehealth(20);
    }

    public void decresehealth(float value)
    {
        myhealthbar.value -= value;
    }
}
