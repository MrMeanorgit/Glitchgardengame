using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [Tooltip("The time this level has")]
    [SerializeField] int leveltimer = 10;
    bool ontriggerlevelfinshed = false;

    // Update is called once per frame
    void Update()
    {
        if(ontriggerlevelfinshed) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / leveltimer;
        bool timehas = (Time.timeSinceLevelLoad >= leveltimer);
        if(timehas)
        {
            Debug.Log("Time Expired");
            FindObjectOfType<levelcontrol>().LevelTimerFinished();
            ontriggerlevelfinshed = true;
        }
    }
}
