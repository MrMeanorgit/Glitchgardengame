using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatingText : MonoBehaviour
{
    [SerializeField] int star = 100;
    Text starText;
    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        updatedisplay();
    }

    private void updatedisplay()
    {
        starText.text = star.ToString();
    }
    public bool enoughstras(int amount)
    {
        return star >= amount;
    }
    public void addstars(int amouht)
    {
        star += amouht;
        updatedisplay();
    }
    public void decreasestars(int spent)
    {
        if (star >= spent)
        {
            star -= spent;
            updatedisplay();
        }
       

    }
}
