using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defende : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int starCost = 100;  //initial starcost
    public void Addstar( int amount)
    {
        FindObjectOfType<UpdatingText>().addstars(amount);    //adding star evnent in trpohy animation
    }

    //making star cost public
    public int Returnstarcost()
    {
       
        return starCost;
    }
}
