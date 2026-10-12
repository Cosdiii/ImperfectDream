# ImperfectDream
# 🎮 2D 敘事解謎遊戲專案 (Unity 3D / C#)

🎓 本專案為大學畢業製作，我擔任**主要程式開發者**，負責核心遊戲機制、對話系統與解謎邏輯的實作。


---

## 📌 專案簡介 (Overview)
* **遊戲類型**：2D 橫向/俯視 敘事解謎遊戲
* **開發工具**：Unity3D, C#, Visual Studio
* **專案職責**：獨立負責全案程式架構、解謎機制邏輯、對話流程整合與 UI 控制。

---

## 🛠️ 核心程式架構與技術亮點 (Technical Highlights)

### 1. 🕹️ 玩家動態控制與邊界管理 (CharacterAMove.cs)
* **多向移動與跑步加速**：透過 Unity 新輸入系統與 Input.GetKey 實現 WASD 四方向平滑移動，並支援 LeftControl 鍵按住進行跑步加速。
* **空間邊界防護與狀態鎖定**：設定嚴格的座標防護網（限制 X/Y 軸極限範圍），避免角色穿模；同時提供 lockPlayer 靜態狀態開關，在進入劇情或對話時精準凍結玩家移動。

### 2. 🔍 碰撞偵測與調查互動系統 (IconE.cs、IconE2.cs、IconE3.cs)
* **物件動態識別**：利用 OnTriggerEnter2D 抓取碰撞物件名稱（如 table`、box`、`door`）。
* **條件式互動提示**：結合遊戲章節進度（`flowerSystemProcess`），動態決定是否顯示調查按鈕（Icon E），並在離開範圍時自動收起介面與切換 BGM。

### 3. 💬 敘事文本與對話系統 (Dialogue & Scripting)
* **Flower 系統腳本整合**：運用 Flower 套件文本指令（如 [show], [w], [r] 等）實作環境調查與劇情對話控管。
* **自製對話管理器 (DialogManager.cs)**：利用 C# 字串分割（`Split`）解析文字資料，實現雙人立繪動態切換、CG 畫面播放與動態分支選項生成。

---
