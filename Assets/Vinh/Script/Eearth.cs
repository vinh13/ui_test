using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eearth : MonoBehaviour
{
    public float speed = 10;
   
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
