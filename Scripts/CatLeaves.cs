using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CatLeaves : MonoBehaviour
{
	[SerializeField] Transform ShrimpIcon;
	[SerializeField] TextMeshPro CatText;
	//bool inventory = ShrimpScript.isInventory;
	public GameObject block;
	bool collided = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if(other.CompareTag("Player")){

        	collided = true;
        	FreeLevel();
        }
    }

    void FreeLevel()
    {
    	if(ShrimpScript.isInventory == true){

	    	ShrimpIcon.gameObject.SetActive(false);
	        Destroy(block);
	        CatText.text = "Thanks! Yummy!";
	        transform.position = transform.position + new Vector3( 100  * Time.deltaTime, 0 *  Time.deltaTime, 0);
	    }
	    if(CoconutPickup.isInventory == true){

	    	ShrimpIcon.gameObject.SetActive(false);
	        Destroy(block);
	        CatText.text = "Thanks! Yummy!";
	        transform.position = transform.position + new Vector3( -200  * Time.deltaTime, 0 *  Time.deltaTime, 0);
	    }
    }
}
