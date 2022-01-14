using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float zombieSpeed = 1f;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetFloat("Speed_f", zombieSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + zombieSpeed * Vector3.forward * Time.deltaTime;
        animator.SetFloat("Speed_f", zombieSpeed);
    }
}
