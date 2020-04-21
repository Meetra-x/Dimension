using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Metal : MonoBehaviour
{

    #region Singleton

    public static Metal instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion


    public float MetalAmount { get; set; }

    public float MetalIncrease { get; set; }
    public float MetalDecrease { get; set; }

    private Text MetalAmountText;

    // Start is called before the first frame update
    void Start()
    {
        MetalAmountText = GameObject.FindGameObjectWithTag(StringTags.MetalAmountTag).GetComponent<Text>();
    }

    public void IncreaseMetalAmount(float _amount)
    {
        MetalAmount += _amount;
        MetalAmountText.text = MetalAmount.ToString();
    }
}
