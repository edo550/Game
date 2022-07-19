using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounterScript : MonoBehaviour
{
    Text coinText;
    public static int coinAmount=0;
    public int ca = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        coinText = GetComponent<Text>();    
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = coinAmount.ToString();
        
        //score = coinAmount;
        
    }


}
