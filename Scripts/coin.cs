using UnityEngine;
using System.Collections;
public class coin : MonoBehaviour 
{
	public static int CoinCount = 0; // Use this for initialization
	public AudioSource getCoin;
	//public static int playercoins = 0; //players coin balance
    void Awake()
    {
        //Object created, increment coin count
		//++coin.CoinCount;
	}

	void OnTriggerEnter(Collider Col){
		//If player collected coin, then destroy object
		if (Col.CompareTag("Player")){
			Destroy(gameObject);
			getCoin.Play();
			++CoinCount;
		}
		//++playercoins;
	}
}
