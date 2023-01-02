using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContextualMenu : MonoBehaviour
{
    public enum MenuTypeEnum { Object, Light }
    public MenuTypeEnum MenuType = new MenuTypeEnum();

    public Text objectTypeText;
}
