using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{

    private Rigidbody proyectilRB;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Fire(float verticalForce) {
        proyectilRB = GetComponent<Rigidbody>();
        proyectilRB.AddForce(new Vector3(0, verticalForce, -3f), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5) {
            Destroy(gameObject);
        }
    }
}
