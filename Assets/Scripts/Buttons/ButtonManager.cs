using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseChromium()
    {
        Chromium.instance.IncreaseChromiumAmount(1);
    }

    public void IncreaseCredits()
    {
        Credits.instance.IncreaseCreditsAmount(1);
    }
}
