using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class UIManager : MonoBehaviour
{

    [FoldoutGroup("Panel Class"), SerializeField]
    MainUI mainUI;

    [FoldoutGroup("Panel Class"), SerializeField]
    ShopUI shopUI;

    [FoldoutGroup("Panel Group"), SerializeField]
    GameObject ShopPanel;


}
