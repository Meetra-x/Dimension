using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Credits : MonoBehaviour
{

    #region Singleton

    public static Credits instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion


    public float CreditsAmount { get; set; }

    public float CreditsIncrease { get; set; }
    public float CreditsDecrease { get; set; }

    private TextMeshProUGUI CreditsAmountText;

    // Start is called before the first frame update
    void Start()
    {
        CreditsAmountText = GameObject.FindGameObjectWithTag(StringTags.CreditsAmountTag).GetComponent<TextMeshProUGUI>();
    }

    #region Shop Funcs

    public void IncreaseCreditsAmount(float _amount)
    {
        CreditsAmount += _amount;
        CreditsAmountText.text = CreditsAmount.ToString("n0");
    }

    public void DecreaseCreditsAmount(float _amount)
    {
        CreditsAmount -= _amount;
        CreditsAmountText.text = CreditsAmount.ToString("n0");
    }

    public bool CanPurchaseWithCredits(float _amount)
    {
        return CreditsAmount >= _amount;
    }

    #endregion
}
