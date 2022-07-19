using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelCounterScript : MonoBehaviour
{
    Text fuelText;
    public static int fuelAmount= 0;

    // Start is called before the first frame update
    void Start()
    {
        fuelText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        fuelText.text = fuelAmount.ToString();
    }
}
