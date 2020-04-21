using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Chromium : MonoBehaviour
{

    #region Singleton

    public static Chromium instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion


    public float ChromiumAmount { get; set; }

    public float ChromiumIncrease { get; set; }
    public float ChromiumDecrease { get; set; }

    private TextMeshProUGUI ChromiumAmountText;

    // Start is called before the first frame update
    void Start()
    {
        ChromiumAmountText = GameObject.FindGameObjectWithTag(StringTags.ChromiumAmountTag).GetComponent<TextMeshProUGUI>();
    }

    public void IncreaseChromiumAmount(float _amount)
    {
        ChromiumAmount += _amount;
        ChromiumAmountText.text = ChromiumAmount.ToString();
    }
}
