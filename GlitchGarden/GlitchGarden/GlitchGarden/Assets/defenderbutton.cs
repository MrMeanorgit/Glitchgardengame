using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defenderbutton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Defende defenderprefab;
    private void OnMouseDown()
    {
        
        var buttons = FindObjectsOfType<defenderbutton>();
        foreach(defenderbutton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);  //changing button color to black when its not selected

        }
        GetComponent<SpriteRenderer>().color = Color.white; //changing color to white when selected
        FindObjectOfType<SpawnDefender>().TypeofDefender(defenderprefab); //seeing what kind of defender it is and passing it to the spwan defender
      
    }
}
