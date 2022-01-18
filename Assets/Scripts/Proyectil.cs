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
        proyectilRB.AddForce(new Vector3(0, verticalForce, -7f), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5) {
            Explode();
        }
    }

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy")) {
            DestroyZombie();
            Destroy(other.gameObject);
        } else if (other.gameObject.CompareTag("Body")) {
            other.gameObject.GetComponentInParent<Zombie>().IncreaseSpeed();
            Explode();
        } else {
            Explode();
        }
    }

    public void Explode() {
            GameController gameController = GameObject.Find("GameController").GetComponent<GameController>();
            gameController.PlayProyectilYellowExplosionAt(transform.position);
            Destroy(gameObject);
    }

    public void DestroyZombie() {
            GameController gameController = GameObject.Find("GameController").GetComponent<GameController>();
            gameController.PlayProyectilRedExplosionAt(transform.position);
            Destroy(gameObject);
    }
}
