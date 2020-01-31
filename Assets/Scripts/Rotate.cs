using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]float turnSpeed = 5;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0,turnSpeed,0)); 

    }
}
