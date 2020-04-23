using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void IncreaseCredits()
    {
        Resources.instance.IncreaseCreditsAmount(1);
    }

    public void IncreaseWorkRobot()
    {
        Resources.instance.robots.AssignRobot(RobotJob.Work);
    } 
    
    public void IncreaseMineRobot()
    {
        Resources.instance.robots.AssignRobot(RobotJob.Mining);
    }

    public void DecreaseWorkRobot()
    {
        Resources.instance.robots.UnassignRobot(RobotJob.Work);
    }

    public void DecreaseMineRobot()
    {
        Resources.instance.robots.UnassignRobot(RobotJob.Mining);
    }

    public void ShopBuyChromium()
    {
        Shop.instance.BuyChromium(1);
    }

    public void ShopBuyRobot()
    {
        Shop.instance.BuyRobot(1);
    }
}
