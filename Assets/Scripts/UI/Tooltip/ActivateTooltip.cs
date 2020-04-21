using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTooltip : MonoBehaviour
{
    GameObject tooltip = null;

    private void Awake()
    {
        foreach(Transform child in transform)
        {
            if(child.name == "Tooltip")
            {
                tooltip = child.gameObject;
            }
        }
    }

    public void OnMouseOver()
    {
        tooltip.SetActive(true);    
    }

    public void OnMouseExit()
    {
        tooltip.SetActive(false);
    }
}
