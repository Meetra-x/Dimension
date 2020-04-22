using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MainUI : MonoBehaviour
{



    [SerializeField]
    public TextMeshProUGUI ChromiumAmountText;

    [SerializeField]
    public TextMeshProUGUI CreditsAmountText;


    void OnEnable()
    {
        Messenger.AddListener<float>(Events.Event_OnUpdateCreditsText, UpdateCreditText);
        Messenger.AddListener<float>(Events.Event_OnUpdateChromiumText, UpdateChromiumText);
    }

    private void OnDisable()
    {
        Messenger.RemoveListener<float>(Events.Event_OnUpdateCreditsText, UpdateCreditText);
        Messenger.RemoveListener<float>(Events.Event_OnUpdateChromiumText, UpdateChromiumText);
    }

    // Start is called before the first frame update
    void Start()
    {

        if (ChromiumAmountText != null)
        {
            ChromiumAmountText.text = Resources.instance.chromium.ChromiumAmount.ToString();
        }
        else { Debug.LogWarning("ChromiumAmountText is null"); }
    }



    public void UpdateChromiumText(float _amount)
    {
        ChromiumAmountText.text = _amount.ToString("n0");
    }

    public void UpdateCreditText(float _amount)
    {
        CreditsAmountText.text = _amount.ToString("n0");
    }
}
