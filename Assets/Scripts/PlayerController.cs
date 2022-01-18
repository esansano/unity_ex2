using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float speed = 1;
    private float verticalForce = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject projectilGO = Instantiate(projectilePrefab, 
            new Vector3(transform.position.x, 0.25f, transform.position.z), 
            transform.rotation);
            projectilGO.GetComponent<Proyectil>().Fire(verticalForce);
        }

        if (Input.GetKey("left")) {
            transform.position = transform.position + Vector3.right * Time.deltaTime * speed;

        } else if (Input.GetKey("right")) {
            transform.position = transform.position + Vector3.left * Time.deltaTime * speed;
        }

        if (Input.GetKey("up")) {
            verticalForce += 0.005f;

        } else if (Input.GetKey("down")) {
            verticalForce -= 0.005f;
        }


    }
}
