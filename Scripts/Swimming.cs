using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swimming : MonoBehaviour
{
	public Animator my_animator;

    // Start is called before the first frame update
    void Start()
    {
        //my_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // to see when the player enters the water
    {
        if(other.CompareTag("Player")){

     		my_animator.SetBool("Swim", true);
        }
    }

    void OnTriggerExit(Collider other) // to see when the player enters the water
    {
        if(other.CompareTag("Player")){

     		my_animator.SetBool("Swim", false);
        }
    }
}
