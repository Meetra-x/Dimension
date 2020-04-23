using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Sirenix.OdinInspector;


public partial class Resources
{
    public class Robots
    {

        //Robot assigning
        public float RobotsMaxAmount { get; set; }

        public float AssignedRobots { get; set; }

        public float RobotsFreeAmount { get; set; }

        //Job robot amounts
        public int WorkRobots { get; set; }
        public int MineRobots { get; set; }

        //UI element vars
        [FoldoutGroup("Resource Texts"), SerializeField]
        public TextMeshProUGUI RobotsMaxAmountText;

        [FoldoutGroup("Resource Texts"), SerializeField]
        public TextMeshProUGUI RobotsFreeAmountText;

        [FoldoutGroup("Resource Texts"), SerializeField]
        public TextMeshProUGUI RobotsWorkAmountText;

        [FoldoutGroup("Resource Texts"), SerializeField]
        public TextMeshProUGUI RobotsMineAmountText;

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
            if (RobotsFreeAmount > 0)
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
}
