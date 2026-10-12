using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonTextAndSceneChanger : MonoBehaviour
{
    // 綁定按鈕的Text元件
    public Text buttonText;

    // 設置一個文字列表，用於顯示不同的文字
    public string[] texts = { "還不行", "我必須成為一個完美的孩子" };

    // 追踪目前顯示的文字索引
    private int currentIndex = 0;

    // 要切換的場景名稱
    public string nextSceneName;

    // 當按鈕點擊時觸發此方法
    public void ChangeTextOrScene()
    {
        if (buttonText != null && texts.Length > 0)
        {
            if (currentIndex < texts.Length)
            {
                // 設定按鈕文字為列表中的當前文字
                buttonText.text = texts[currentIndex];
                currentIndex++;
            }
            else
            {
                // 當到達最後一個文字後，切換到下一個場景
                SceneManager.LoadScene(01);
            }
        }
    }
}
