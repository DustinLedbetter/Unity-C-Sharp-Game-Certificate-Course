using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//blueprint class for player object
public class Player {


    //character details
    protected int health;
    protected int power;
    protected string name;


    //player constructor (has nothing passed to it
    public Player()
    {

    }


    //this will display stats of character created.
    public void Info()
    {
        Debug.Log("Player created, Health: " + this.health + " Power: " + this.power + " Name: " + this.name);
    }


    //this will display 
    public virtual void Attack()
    {
        Debug.Log("Player is attacking");
    }
}
