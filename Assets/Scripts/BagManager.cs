using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagManager : MonoBehaviour
{
    public GameObject backpackUI; // 背包UI物體（Canvas等）
    private bool isBackpackOpen = false; // 背包開關狀態

    void Start()
    {
        // 初始設定背包為關閉狀態
        CloseBackpack();
    }

    void Update()
    {
        // 監聽玩家輸入，按下F鍵切換背包開關狀態
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isBackpackOpen)
                CloseBackpack(); // 如果背包已打開，則關閉背包
            else
                OpenBackpack(); // 如果背包未打開，則打開背包
        }
    }

    void OpenBackpack()
    {
        backpackUI.SetActive(true); // 顯示背包UI
        isBackpackOpen = true; // 設定背包為打開狀態
    }

    void CloseBackpack()
    {
        backpackUI.SetActive(false); // 隱藏背包UI
        isBackpackOpen = false; // 設定背包為關閉狀態
    }



public BagUnit m_CloneUnit = null;
    public Transform m_BagNode = null;

    public Sprite[] m_TotalItemSprite = null;

    public List<ItemData>m_TotalItemData = new List<ItemData>();

    private void Awake()
    {
        


    }


    public void OnClickUnit(BagUnit unit)
    {
 
    }

}

public class ItemData
{
    public Sprite m_Icon = null;
    public int m_ItemTag = 0;
    public bool m_IsSelected = false;
    public bool m_IsEquiped = false;
}

