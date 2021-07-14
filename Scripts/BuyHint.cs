using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityStandardAssets.CrossPlatformInput;

public class BuyHint : MonoBehaviour
{
	[SerializeField] TextMeshPro RabbitAsk;
	[SerializeField] TextMeshPro RabbitAnswer;
	public int coins;
	public static bool hint = false; //if bought hint

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	coins = coin.CoinCount;
        if (Input.GetKey(KeyCode.H) && coins >= 10)  //if player pressed H to buy help and they have at least 10 coins
        {
        	hint = true;
        	RabbitAsk.gameObject.SetActive(false);  //hide asking text
        	RabbitAnswer.gameObject.SetActive(true); //show asnwer
        }
    }
}