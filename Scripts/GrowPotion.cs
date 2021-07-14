using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowPotion : MonoBehaviour
{
	public GameObject player;
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

     		player.transform.localScale += new Vector3(2,2,2);
     		Destroy(gameObject);
        }
    }
}
