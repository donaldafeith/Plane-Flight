using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public GameObject propeller;
    public float propSpeed = -1000;


    // Update is called once per frame
    void Update()
    {
        propeller.transform.Rotate(0, 0, propSpeed * Time.deltaTime);
       }
}
