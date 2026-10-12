using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public AudioSource bgm1; // 第一首音樂的 Audio Source
    public AudioSource bgm2; // 第二首音樂的 Audio Source

    private AudioSource currentBGM; // 當前播放的音樂

    void Start()
    {
        // 停止所有音樂，然後播放預設的第一首
        bgm1.Stop();
        bgm2.Stop();

        // 預設播放第一首音樂
        currentBGM = bgm1;
        PlayBGM(currentBGM);
    }

    // 播放指定的音樂
    public void PlayBGM(AudioSource bgm)
    {
        if (currentBGM != null && currentBGM.isPlaying)
        {
            currentBGM.Stop(); // 停止當前播放的音樂
        }

        currentBGM = bgm;
        currentBGM.Play();
    }

    // 觸發條件切換音樂
    public void SwitchToBGM2()
    {
        PlayBGM(bgm2); // 切換到第二首音樂
    }

    public void SwitchToBGM1()
    {
        PlayBGM(bgm1); // 切換回第一首音樂
    }
}
