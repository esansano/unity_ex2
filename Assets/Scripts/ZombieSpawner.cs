using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnZombie", 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnZombie() {
        float x = Random.Range(-5f, 5f);
        Vector3 zombiePosition = new Vector3(x, transform.position.y, transform.position.z);
        Instantiate(zombiePrefab, zombiePosition, transform.rotation);
    }
}
