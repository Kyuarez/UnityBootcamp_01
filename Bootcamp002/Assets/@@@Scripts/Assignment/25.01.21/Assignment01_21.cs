using System;
using System.Collections.Generic;
using UnityEngine;


/* [01.21 °úÁ¦]
 1. AddComponent -> result : TK/Assignment01_21

 2. Variable 
 - Jump (bool)
 - Fruits (enum)
 - Money (int)
 - Field View (Range)
 - Rainbow (enum)
 */

[Flags]
public enum FRUITSBASKET
{
    None = 0,
    Apple = 1,
    Banana = 1 << 1,
    Orange = 1 << 2,
    Mango = 1 << 3,
}

public enum RAINBOW
{
    Red,
    Orange,
    Yellow,
    Green,
    Blue,
    Sodomy,
    Purple
}

[AddComponentMenu("TK/Assignment01_21")]
public class Assignment01_21 : MonoBehaviour
{
    #region Variable
    public bool _isJump;
    public FRUITSBASKET _basket;
    public int _money;
    [Range(0, 99)] public float _fieldView;
    public List<RAINBOW> _rainbow;    
    #endregion
}
