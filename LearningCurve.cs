using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character();
        Debug.LogFormat("hero:{0} - {1} EXP", hero.name, hero.exp);

        Character heroine = new Character("Agatha");
        Debug.LogFormat("hero:{0} - {1} EXP", heroine.name, heroine.exp);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
