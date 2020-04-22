using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public partial class Resources : MonoBehaviour
{

    #region Singleton

    public static Resources instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    #endregion

    [SerializeField]
    public Credits credits = new Credits();
    [SerializeField]
    public Chromium chromium = new Chromium();
    [SerializeField]
    public Robots robots = new Robots();



    void Start()
    {
        /*
        #region Robots
        //For testing
        robots.RobotsFreeAmount = 1;
        robots.RobotsMaxAmount = 1;

        //Initilise the GameObjects
        if (robots.RobotsMaxAmountText != null)
        {
            robots.RobotsMaxAmountText.text = robots.RobotsMaxAmount.ToString();
        }
        else { Debug.LogWarning("RobotsMaxAmountText is null"); }

        if (robots.RobotsFreeAmountText != null)
        {
            robots.RobotsFreeAmountText.text = robots.RobotsFreeAmount.ToString();
        }
        else { Debug.LogWarning("RobotsFreeAmountText is null"); }

        if (robots.RobotsWorkAmountText != null)
        {
            robots.RobotsWorkAmountText.text = robots.WorkRobots.ToString();
        }
        else { Debug.LogWarning("RobotsWorkAmountText is null"); }

        if (robots.RobotsMineAmountText != null)
        {
            robots.RobotsMineAmountText.text = robots.MineRobots.ToString();
        }
        else { Debug.LogWarning("RobotsMineAmountText is null"); }
        #endregion
        */
    }


    public void PurchaseCreditsAndChromium(float _creditAmount, float _chromiumAmount)
    {
        credits.DecreaseCreditsAmount(_creditAmount);
        chromium.DecreaseChromiumAmount(_chromiumAmount);
    }

}
