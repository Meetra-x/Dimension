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
        if (Resources.instance.credits.CanPurchaseWithCredits(cost))
        {
            //Actually purchase
            Resources.instance.credits.DecreaseCreditsAmount(cost);
            Resources.instance.chromium.IncreaseChromiumAmount(_amount);
        }
    }

    public void BuyRobot(float _amount, float _ratio = 1)
    {
        //Work out the cost in credits
        float creditCost = _amount * _ratio;
        float chromiumCost = _amount * _ratio;
        //Check can purchase
        if (Resources.instance.credits.CanPurchaseWithCredits(creditCost) && Resources.instance.chromium.CanPurchaseWithChromium(chromiumCost))
        {
            //Actually purchase
            Resources.instance.PurchaseCreditsAndChromium(creditCost, chromiumCost);
            Resources.instance.robots.IncreaseRobotsAmount(1);
        }
    }



}
