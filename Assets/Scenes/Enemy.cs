using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int level;
    public int hpValue;
}
    // Start is called before the first frame update
    void Start()
    {
        //set level stat
        level = randomNumber(0, 20);
        //set HPvalue
        hpValue = 5 + level;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}