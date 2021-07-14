using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingRodPickup : MonoBehaviour
{
  public Animator fishingAnimator;

    void Start()
    {
        fishingAnimator = GetComponent<Animator>();
        
    }
  
    void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if(other.CompareTag("Player")){
        
            //if (Input.GetKeyDown(KeyCode.X)) {  //if player presses X to fish trigger animation of fishing
                
            fishingAnimator.SetBool("isSelected", true);

            //}
        }
    }

}
