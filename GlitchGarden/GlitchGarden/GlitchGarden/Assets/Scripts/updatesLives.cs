using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updatesLives : MonoBehaviour
{
    [SerializeField] float  baselives = 3;
    [SerializeField] int damage = 1;
    Text livetext;
    float Lives;

    // Start is called before the first frame update
    void Start()
    {
        Lives = baselives - PlayerPrefsController.GetDifficulty();
        livetext = GetComponent<Text>();
        updatedisplay();
        Debug.Log("Difficulty level is" + PlayerPrefsController.GetDifficulty());
    }
    private void updatedisplay()
    {
        livetext.text = Lives.ToString();
    }
    public void decreaselives()
    {
  
            Lives -= damage;
            updatedisplay();
        if(Lives <= 0)
        {
            FindObjectOfType<levelcontrol>().Handlelosecondition();
        }


    }

    
}
