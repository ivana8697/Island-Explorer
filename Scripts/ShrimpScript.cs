using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrimpScript : MonoBehaviour
{
	[SerializeField] Transform ShrimpIcon;
	public static bool isInventory = false; //if shrimp is in inventory
    // Start is called before the first frame update
    void Start()
    {
        ShrimpIcon.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if(other.CompareTag("Player")){

        	ShrimpIcon.gameObject.SetActive(true);
        	Destroy(gameObject);
        	isInventory = true;

        }
    }

}
