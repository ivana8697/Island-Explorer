using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
	public int coins = coin.CoinCount;
	public Text count;
	public bool hintBought;
    // Start is called before the first frame update
    void Start()
    {
        count.text = "Coins: " + coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        coins = coin.CoinCount;
        hintBought = BuyHint.hint;
        if (hintBought == true)
        {
        	coins = coins - 10;
        }
        count.text = "Coins: " + coins.ToString();

    }
}
