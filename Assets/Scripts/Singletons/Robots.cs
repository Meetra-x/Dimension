using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Sirenix.OdinInspector;

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
    [FoldoutGroup("Reource Texts"), SerializeField]
    private TextMeshProUGUI RobotsMaxAmountText;

    [FoldoutGroup("Reource Texts"), SerializeField]
    private TextMeshProUGUI RobotsFreeAmountText;
    
    [FoldoutGroup("Reource Texts"), SerializeField]
    private TextMeshProUGUI RobotsWorkAmountText;
    
    [FoldoutGroup("Reource Texts"), SerializeField]
    private TextMeshProUGUI RobotsMineAmountText;


    // Start is called before the first frame update
    void Start()
    {
        //For testing
        RobotsFreeAmount = 1;
        RobotsMaxAmount = 1;

        //Initilise the GameObjects
        if (RobotsMaxAmountText != null)
        {
            RobotsMaxAmountText.text = RobotsMaxAmount.ToString();
        } else { Debug.LogWarning("RobotsMaxAmountText is null"); }

        if (RobotsFreeAmountText != null)
        {
            RobotsFreeAmountText.text = RobotsFreeAmount.ToString();
        }
        else { Debug.LogWarning("RobotsFreeAmountText is null"); }

        if (RobotsWorkAmountText != null)
        {
            RobotsWorkAmountText.text = WorkRobots.ToString();
        }
        else { Debug.LogWarning("RobotsWorkAmountText is null"); }

        if (RobotsMineAmountText != null)
        {
            RobotsMineAmountText.text = MineRobots.ToString();
        }
        else { Debug.LogWarning("RobotsMineAmountText is null"); }

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
