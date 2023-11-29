using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fornpc : MonoBehaviour
{
    int speed = 10;
    float ss = 100.4f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
