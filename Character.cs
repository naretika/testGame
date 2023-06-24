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

    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Hero:{0} - {1} EXP", name, exp);
    }

    public Character (string name)
    {
        this.name = name;
    }

    private void Reset () 
    {
        this.name = "not assigned";
         this.exp = 0;
    }
}

public class Paladin: Character
{
    public int age;
    public Weapon weapon;
    public Paladin(string name, int age, Weapon weapon) : base(name)
    {
        this.age = age;
        this.weapon = weapon;
    }

    public Paladin(string name) : base(name)
    {

    }
    public void PrintAge()
    {
        Debug.LogFormat("Paladin age:{0} - {1} years", name, age);
    }

    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take your {1}!", name, weapon.name);
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
