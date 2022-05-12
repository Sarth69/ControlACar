using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);
    }
}
