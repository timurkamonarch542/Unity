using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    int health = 50;
    int heal = 10;

    void Start()
    {
        health = 50;
       heal = 10;
       health = health + heal;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
