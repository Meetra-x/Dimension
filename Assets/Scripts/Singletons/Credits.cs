using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    private Text CreditsAmountText;

    // Start is called before the first frame update
    void Start()
    {
        CreditsAmountText = GameObject.FindGameObjectWithTag(StringTags.CreditsAmountTag).GetComponent<Text>();
    }

    public void IncreaseCreditsAmount(float _amount)
    {
        CreditsAmount += _amount;
        CreditsAmountText.text = CreditsAmount.ToString();
    }
}
