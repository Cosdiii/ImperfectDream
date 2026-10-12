using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagUnit : MonoBehaviour
{

    public Image m_Icon = null;
    public Text m_EquipText = null;
    public Text m_SelectText = null;

    public ItemData m_TempData = null;

    public void Refresh(ItemData itemData)
    {
        if(itemData == null)
        {
            m_Icon.sprite = null;
            m_EquipText.text = "";
            m_SelectText.text = "";
            return;
        }
        m_TempData = itemData;
        m_Icon.sprite = itemData.m_Icon;
        m_EquipText.text = "";
        m_SelectText.text = "";
 
    }

    public void OnEquip()
    {
        m_TempData.m_IsEquiped = true;
        m_EquipText.text = "裝備中";
    }

    public void OnSelect()
    {
        m_TempData.m_IsSelected = true;
        m_SelectText.text = "文字說明";
    }


}
