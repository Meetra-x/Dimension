using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class Resources
{
    public class Chromium
    {
        public float ChromiumAmount { get; set; }

        public float ChromiumIncrease { get; set; }
        public float ChromiumDecrease { get; set; }    

        #region Shop Funcs
        public void IncreaseChromiumAmount(float _amount)
        {
            ChromiumAmount += _amount;
            Messenger.Broadcast<float>(Events.Event_OnUpdateChromiumText, ChromiumAmount);
        }
        public void DecreaseChromiumAmount(float _amount)
        {
            ChromiumAmount -= _amount;
            Messenger.Broadcast<float>(Events.Event_OnUpdateChromiumText, ChromiumAmount);
        }
        public bool CanPurchaseWithChromium(float _amount)
        {
            return ChromiumAmount >= _amount;
        }
        #endregion

    }
}
