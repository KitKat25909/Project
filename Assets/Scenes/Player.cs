using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int damage;
    public int level;
    public int levelup;
    public int maxlevel;
    // Start is called before the first frame update
    void Start()
    {
        //set damage stat
        damage = 5;
        //set start level stat
        level = 0;
        //set level up stats
        levelup = level + damage;
        //set max level stat
        maxlevel = 5;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("EXP gained");
            Debug.Log("Winner!!");
        }

    }
}