using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{

    private Rigidbody proyectilRB;
    // Start is called before the first frame update
    void Start()
    {
        proyectilRB = GetComponent<Rigidbody>();
        proyectilRB.AddForce(new Vector3(0, 2.5f, -6f), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
