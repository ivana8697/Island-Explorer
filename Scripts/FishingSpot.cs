using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingSpot : MonoBehaviour
{
	public GameObject fish;
	public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        fish.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if(other.CompareTag("Player")){

     		//isFishing();
     		fish.active = true;
        }
    }

    //void isFishing()
    //{
    //	if(animator.GetBool("Fish")){  //if fishing then shrimp shows up on floor

    //		fish.active = true;
	//    }
    //}
}
