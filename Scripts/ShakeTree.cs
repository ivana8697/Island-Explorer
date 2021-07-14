using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ShakeTree : MonoBehaviour
{
	public Animator my_animator;
	public GameObject coconut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator OnTriggerEnter(Collider other) // to see when the player enters the water
    {
        if(other.CompareTag("Player") && (Input.GetKey(KeyCode.B)))
        {

     		my_animator.SetBool("Shake", true);
     		yield return new WaitForSeconds(2);
     		coconut.active = true;
     		my_animator.SetBool("Shake", false);

        }
    }
}
