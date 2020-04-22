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

    [SerializeField]
    private TextMeshProUGUI ChromiumAmountText;

    // Start is called before the first frame update
    void Start()
    {
        ChromiumAmount = 0;

        if (ChromiumAmountText != null)
        {
            ChromiumAmountText.text = ChromiumAmount.ToString();
        }
        else { Debug.LogWarning("RobotsMaxAmountText is null"); }
    }

    #region Shop Funcs
    public void IncreaseChromiumAmount(float _amount)
    {
        ChromiumAmount += _amount;
        ChromiumAmountText.text = ChromiumAmount.ToString();
    }
    public void DecreaseChromiumAmount(float _amount)
    {
        ChromiumAmount -= _amount;
        ChromiumAmountText.text = ChromiumAmount.ToString();
    }
    public bool CanPurchaseWithChromium(float _amount)
    {
        return ChromiumAmount >= _amount;
    }
    #endregion

}
