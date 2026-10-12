using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumMove : MonoBehaviour
{
    public Text numberText; // 用來顯示數字的Text元件
    public int Num; // 用來存儲當前顯示的數字

    private void Start()
    {
        Num = 0; // 初始值設為0
        UpdateText(); // 更新顯示的數字
    }

    /// <summary>
    /// 更新Text元件中的數字
    /// </summary>
    private void UpdateText()
    {
        numberText.text = Num.ToString(); // 將數字轉換為字串並顯示
    }

    /// <summary>
    /// 增加數字
    /// </summary>
    public void PageUp()
    {
        Num += 1; // 增加數字
        if (Num > 9)
        {
            Num = 0; // 如果大於9，重置為0
        }
        UpdateText(); // 更新顯示的數字
    }

    /// <summary>
    /// 減少數字
    /// </summary>
    public void PageDown()
    {
        Num -= 1; // 減少數字
        if (Num < 0)
        {
            Num = 9; // 如果小於0，重置為9
        }
        UpdateText(); // 更新顯示的數字
    }
}
