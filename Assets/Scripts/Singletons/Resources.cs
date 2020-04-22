using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Sirenix.OdinInspector;

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

    [FoldoutGroup("Resource Classes"), SerializeField]
    public Credits credits = new Credits();
    [FoldoutGroup("Resource Classes"), SerializeField]
    public Chromium chromium = new Chromium();
    [FoldoutGroup("Resource Classes"), SerializeField]
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
        DecreaseCreditsAmount(_creditAmount);
        DecreaseChromiumAmount(_chromiumAmount);
    }



    #region Credit Functions

    public void IncreaseCreditsAmount(float _amount)
    {
        credits.CreditsAmount += _amount;
        Messenger.Broadcast<float>(Events.Event_OnUpdateCreditsText, credits.CreditsAmount);
    }

    public void DecreaseCreditsAmount(float _amount)
    {
        credits.CreditsAmount -= _amount;
        Messenger.Broadcast<float>(Events.Event_OnUpdateCreditsText, credits.CreditsAmount);
    }

    public bool CanPurchaseWithCredits(float _amount)
    {
        return credits.CreditsAmount >= _amount;
    }

    #endregion

    #region Chromium Functions
    public void IncreaseChromiumAmount(float _amount)
    {
        chromium.ChromiumAmount += _amount;
        Messenger.Broadcast<float>(Events.Event_OnUpdateChromiumText, chromium.ChromiumAmount);
    }
    public void DecreaseChromiumAmount(float _amount)
    {
        chromium.ChromiumAmount -= _amount;
        Messenger.Broadcast<float>(Events.Event_OnUpdateChromiumText, chromium.ChromiumAmount);
    }
    public bool CanPurchaseWithChromium(float _amount)
    {
        return chromium.ChromiumAmount >= _amount;
    }
    #endregion

}
