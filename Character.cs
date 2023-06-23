using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        name = "Not Assigned";
    }

    public void PrintStatsInfo()
    {
        Debug.LogFormat("hero:{0} - {1} EXP", name, exp);
    }

    public Character (string name)
    {
        this.name = name;
    }
}

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name=name;
        this.damage = damage;
    }
    public void PrintWeaponStats()
    {
        Debug.LogFormat("weapon: {0} - {1} DMB", name, damage);
    }
}
