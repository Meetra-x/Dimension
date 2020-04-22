using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class Resources
{
    public class Credits
    {

        public float CreditsAmount { get; set; }

        public float CreditsIncrease { get; set; }
        public float CreditsDecrease { get; set; }

        #region Shop Funcs

        public void IncreaseCreditsAmount(float _amount)
        {
            CreditsAmount += _amount;
            Messenger.Broadcast<float>(Events.Event_OnUpdateCreditsText, CreditsAmount);
        }

        public void DecreaseCreditsAmount(float _amount)
        {
            CreditsAmount -= _amount;
            Messenger.Broadcast<float>(Events.Event_OnUpdateCreditsText, CreditsAmount);
        }

        public bool CanPurchaseWithCredits(float _amount)
        {
            return CreditsAmount >= _amount;
        }

        #endregion
    }
}