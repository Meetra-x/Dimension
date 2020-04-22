using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Sirenix.OdinInspector;

public class ShopUI : MonoBehaviour
{

    [FoldoutGroup("Resource Text"), SerializeField]
    public TextMeshProUGUI CreditsAmountText;

    [FoldoutGroup("Resource Text"), SerializeField]
    public TextMeshProUGUI ChromiumAmountText;


    private void OnEnable()
    {
        Messenger.AddListener<float>(Events.Event_OnUpdateCreditsText, UpdateCreditText);
        Messenger.AddListener<float>(Events.Event_OnUpdateChromiumText, UpdateChromiumText);
    }

    private void OnDisable()
    {
        Messenger.RemoveListener<float>(Events.Event_OnUpdateCreditsText, UpdateCreditText);
        Messenger.RemoveListener<float>(Events.Event_OnUpdateChromiumText, UpdateChromiumText);
    }

    public void UpdateCreditText(float _amount)
    {
        CreditsAmountText.text = _amount.ToString("n0");
    }
    public void UpdateChromiumText(float _amount)
    {
        ChromiumAmountText.text = _amount.ToString("n0");
    }

}
