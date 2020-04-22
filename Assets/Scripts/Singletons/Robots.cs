using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Robots : MonoBehaviour
{

    #region Singleton

    public static Robots instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion


    //Robot assigning
    public float RobotsMaxAmount { get; set; }

    public float AssignedRobots { get; set; }

    public float RobotsFreeAmount { get; set; }


    //Job robot amounts
    public int WorkRobots { get; set; }
    public int MineRobots { get; set; }


    //UI element vars
    private TextMeshProUGUI RobotsMaxAmountText;
    private TextMeshProUGUI RobotsFreeAmountText;
    private TextMeshProUGUI RobotsWorkAmountText;
    private TextMeshProUGUI RobotsMineAmountText;

    // Start is called before the first frame update
    void Start()
    {
        //For testing
        RobotsFreeAmount = 1;
        RobotsMaxAmount = 1;


        //Initilise the GameObjects
        RobotsMaxAmountText = GameObject.FindGameObjectWithTag(StringTags.RobotsMaxAmountTag).GetComponent<TextMeshProUGUI>();
        RobotsMaxAmountText.text = RobotsMaxAmount.ToString();
        RobotsFreeAmountText = GameObject.FindGameObjectWithTag(StringTags.RobotsFreeAmountTag).GetComponent<TextMeshProUGUI>();
        RobotsFreeAmountText.text = RobotsFreeAmount.ToString();
        RobotsWorkAmountText = GameObject.FindGameObjectWithTag(StringTags.RobotsWorkAmountTag).GetComponent<TextMeshProUGUI>();
        RobotsWorkAmountText.text = WorkRobots.ToString();
        //RobotsMineAmountText = GameObject.FindGameObjectWithTag(StringTags.RobotsMineAmountTag).GetComponent<TextMeshProUGUI>();
    }

    public void IncreaseRobotsAmount(float _amount)
    {
        RobotsMaxAmount += _amount;
        RobotsFreeAmount += _amount;
        RobotsMaxAmountText.text = RobotsMaxAmount.ToString();
        RobotsFreeAmountText.text = RobotsFreeAmount.ToString();
        RobotsWorkAmountText.text = WorkRobots.ToString();
    }

    public void AssignRobot(RobotJob _robotJob)
    {
        if(RobotsFreeAmount > 0)
        {
            switch (_robotJob)
            {
                case RobotJob.Work:
                    WorkRobots++;
                    RobotsWorkAmountText.text = WorkRobots.ToString();
                    RobotsFreeAmount--;
                    RobotsFreeAmountText.text = RobotsFreeAmount.ToString();
                    break;
                case RobotJob.Mining:
                    MineRobots++;
                    RobotsFreeAmount--;
                    RobotsFreeAmountText.text = RobotsFreeAmount.ToString();
                    break;
                default:
                    break;
            }
        }
    }

    public void UnassignRobot(RobotJob _robotJob)
    {
        if (RobotsFreeAmount == 0)
        {
            switch (_robotJob)
            {
                case RobotJob.Work:
                    WorkRobots--;
                    RobotsWorkAmountText.text = WorkRobots.ToString();
                    RobotsFreeAmount++;
                    RobotsFreeAmountText.text = RobotsFreeAmount.ToString();
                    break;
                case RobotJob.Mining:
                    MineRobots--;
                    RobotsFreeAmount++;
                    RobotsFreeAmountText.text = RobotsFreeAmount.ToString();
                    break;
                default:
                    break;
            }
        }
    }

}
