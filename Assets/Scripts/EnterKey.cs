using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterKey : MonoBehaviour
{
    public NumMove[] slot; // 存放每個數字格子的 NumMove 組件
    private string password; // 正確密碼
    private string inputPassword; // 用來存儲玩家的輸入

    private void Start()
    {
        password = "26"; // 設置正確的密碼
    }

    /// <summary>
    /// 檢查密碼是否正確
    /// </summary>
    public void CheckPass()
    {
        inputPassword = ""; // 清空之前的輸入

        // 遍歷每個 NumMove 格子，將數字組合成一個字符串
        for (int i = 0; i < slot.Length; i++)
        {
            inputPassword += slot[i].Num.ToString(); // 從每個格子中獲取數字並拼接
        }

        // 檢查組合後的字符串是否與正確密碼匹配
        if (inputPassword == password)
        {
            print("解鎖成功");
        }
        else
        {
            print("密碼錯誤");
        }
    }
}
