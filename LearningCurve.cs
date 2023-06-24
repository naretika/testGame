using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private Transform camTransform;
    private Transform lightTransform;
    public GameObject directionLight;


    // Start is called before the first frame update
    void Start()
    {
        //Transform camTransform = GetComponent<Transform>();
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        //directionLight = GameObject.Find("Diretional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);

        /*
        Character hero = new Character();
        hero.PrintStatsInfo();

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();
// это структура, она не хранит ссылки
        Weapon weapon = new Weapon("Hounting Bow", 105);
        Weapon hountingBow = new Weapon("Hounting Bow", 105);
        Weapon warBow = hountingBow;
        hountingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();
        warBow.name = "pushka";
        warBow.damage = 50;
        warBow.PrintWeaponStats();
        hountingBow.PrintWeaponStats();


// А это класс, оперирует ссылками, а так, та же петрушка, что и структура, но значения поменяются в обеих ячейках
        Character hero2 = hero;
        hero2.name = "Torvik";
        hero2.PrintStatsInfo();
        hero.PrintStatsInfo();

        //hero2.Reset();

        //тестирование наследования классов

        Paladin knight = new Paladin("Sir Arthur", 34, hountingBow);
        knight.exp = 20;
        knight.PrintStatsInfo();
        knight.PrintAge();
*/
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
