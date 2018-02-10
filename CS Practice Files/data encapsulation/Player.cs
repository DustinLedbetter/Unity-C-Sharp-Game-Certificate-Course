using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//blueprint class for player object
public class Player
{


    //character properties
    private int Health;
    private int Power;
    private string Name;


    //player constructor (has nothing passed to it
    public Player()
    {
        //set properties
        Health = 150;
        Power = 100;
        Name = "warrior";

    }

    //data encapsulation functions

    //getter for health
    public int GetHealth()
    {
        return this.Health;
    }

    //setter for health
    public void SetHealth(int health)
    {
        this.Health = health;
    }

    //getter for power
    public int GetPower()
    {
        return this.Power;
    }

    //setter for power
    public void SetPower(int power)
    {
        this.Power = power;
    }

    //getter for name
    public string GetName()
    {
        return this.Name;
    }

    //setter for name
    public void SetName(string name)
    {
        this.Name = name;
    }
}
