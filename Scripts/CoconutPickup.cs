using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutPickup : MonoBehaviour
{
	[SerializeField] Transform CoconutIcon;
	public static bool isInventory = false; //if coconut is in inventory
    // Start is called before the first frame update
    void Start()
    {
        CoconutIcon.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if(other.CompareTag("Player")){

        	CoconutIcon.gameObject.SetActive(true);
        	Destroy(gameObject);
        	isInventory = true;

        }
    }

}

