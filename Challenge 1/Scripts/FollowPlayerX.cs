using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(7.9f, 0.8f, -0.6f);


    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
