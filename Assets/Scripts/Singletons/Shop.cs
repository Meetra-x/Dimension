using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    #region Singleton

    public static Shop instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BuyChromium(float _amount, float _ratio = 1)
    {
        //Work out the cost in credits
        float cost = _amount * _ratio;
        //Check can purchase
        if (Credits.instance.CanPurchaseWithCredits(cost))
        {
            //Actually purchase
            Credits.instance.DecreaseCreditsAmount(cost);
            Chromium.instance.IncreaseChromiumAmount(_amount);
        }
    }

    public void BuyRobot(float _amount, float _ratio = 1)
    {
        //Work out the cost in credits
        float creditCost = _amount * _ratio;
        float chromiumCost = _amount * _ratio;
        //Check can purchase
        if (Credits.instance.CanPurchaseWithCredits(creditCost) && Chromium.instance.CanPurchaseWithChromium(chromiumCost));
        {          
            //Actually purchase
            Credits.instance.DecreaseCreditsAmount(creditCost);
            Chromium.instance.DecreaseChromiumAmount(chromiumCost);
            Robots.instance.IncreaseRobotsAmount(1);
        }
    }



}
