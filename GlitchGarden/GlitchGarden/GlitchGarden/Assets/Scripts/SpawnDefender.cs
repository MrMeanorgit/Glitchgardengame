using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDefender : MonoBehaviour
{
    Defende Defender; //we generated class type of defender
    int worldpos; //it is the world position
    int defendercost;
    GameObject defenderparent;
    const string DEFENDER_PAREENT_NAME = "defend";

    private void Start()
    {
        createdefenderparent();
    }

    private void createdefenderparent()
    {
        defenderparent = GameObject.Find(DEFENDER_PAREENT_NAME);
        if(!defenderparent)
        {
            defenderparent = new GameObject(DEFENDER_PAREENT_NAME);
        }
    }

    private void OnMouseDown()
    {

        //Debug.Log("mouse was clicked");
        Attmpttoplacedefender(Gettileclicked());  //to spawn defender when we clicked
    }
    private Vector2 Gettileclicked()  //getting the mouse position as the output wrt world and to make it at cenetr we converted to grids
    {
        Vector2 clickpos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldpos = Camera.main.ScreenToWorldPoint(clickpos);
        Vector2 gridpos = Snaptogrid(worldpos);
        return gridpos;

    }

    private void Attmpttoplacedefender(Vector2 gridpos)
    {
        var Stardisplay = FindObjectOfType<UpdatingText>();
        int defendercost = Defender.Returnstarcost();
       

        if(Stardisplay.enoughstras(defendercost))
        {
            spawndefender(gridpos);
            Stardisplay.decreasestars(defendercost);
        }
    }
    public void TypeofDefender(Defende selecteddefender)
    {
        Defender = selecteddefender;   //here after clicking the defender in defenderbutton we are assigning that defender to current defender
    }
    private Vector2 Snaptogrid( Vector2 rawpos)//rounding off the worldpos to inter to sit exactly middle of the each square
    {
        float newX = Mathf.RoundToInt(rawpos.x);
        float newY = Mathf.RoundToInt(rawpos.y);
        return new Vector2(newX, newY);
    }

    private void spawndefender(Vector2 worldpos)//this takes vector2 as input and spawn the particular defender at that place
    {

       Defende newDefender = Instantiate(Defender, worldpos, Quaternion.identity) as Defende;
        newDefender.transform.parent = defenderparent.transform;
       // Debug.Log(worldpos);
        
        
        //FindObjectOfType<UpdatingText>().decreasestars(40); //self created code to decrese the stars when defender is selected
    }
}
