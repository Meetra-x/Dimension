using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseChromium()
    {
        Chromium.instance.IncreaseChromiumAmount(1);
    }

    public void IncreaseCredits()
    {
        Credits.instance.IncreaseCreditsAmount(1);
    }

    public void IncreaseWorkRobot()
    {
        Robots.instance.AssignRobot(RobotJob.Work);
    } 
    
    public void IncreaseMineRobot()
    {
        Robots.instance.AssignRobot(RobotJob.Mining);
    }

    public void DecreaseWorkRobot()
    {
        Robots.instance.UnassignRobot(RobotJob.Work);
    }

    public void DecreaseMineRobot()
    {
        Robots.instance.UnassignRobot(RobotJob.Mining);
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
