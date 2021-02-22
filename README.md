# hiwinrobot

[![GitHub release](https://img.shields.io/github/release/nfu-irs-lab/hiwinrobot.svg)](https://github.com/nfu-irs-lab/hiwinrobot/releases)
[![GitHub repo size](https://img.shields.io/github/repo-size/nfu-irs-lab/hiwinrobot)](https://github.com/nfu-irs-lab/hiwinrobot)
[![GitHub issues](https://img.shields.io/github/issues/nfu-irs-lab/hiwinrobot.svg)](https://github.com/nfu-irs-lab/hiwinrobot/issues)

## 目錄
- [整體架構](#整體架構)
- [使用方法](#使用方法)
  - [HRSDK.dll](#HRSDKdll)
  - [NuGet Packages](#NuGet-Packages)
  - [連線及檔案設定](#連線及檔案設定)
- [版本及兼容性](#版本及兼容性)
- [其它資源](#其它資源)

---

# 整體架構
- [HIWIN_Robot](/HIWIN_Robot.sln)：主要 Solution。
  - [MainForm](/MainForm/)：主要視窗、實際執行及最高層次程式。提供基本、共用的功能視窗。
  - [Contest](/Contest/)：各比賽關卡或用途的專屬程式。
  - [Features](/Features/)：各功能的底層函式庫。
  - [Features.UnitTests](/Features.UnitTests/)：「Features」的單元測試。

# 使用方法
## HRSDK.dll
請將正確版本的「HRSDK.dll」檔案放在目前程式執行的工作路徑下，例如：`MainForm\bin\x64\Debug\`。

工作路徑會因 Visual Studio 的編譯及執行設定不同而改變，例如「Any CPU」、「x86」、「x64」和「Debug」、「Release」。

## NuGet Packages
首次執行前，請執行以下步驟：
1. 以 Visual Studio 開啓 Solution 檔 「[HIWIN_Robot.sln](/HIWIN_Robot.sln)」。
2. 在 Visual Studio 的「Solution Explorer」中，對本 Solution「Solution 'HIWIN_Robot'」點擊滑鼠右鍵。
3. 點選右鍵清單中的「Restore NuGet Packages」，等待其完成。
4. 確認資料夾「packages」及其內容已經於 Solution 路徑下自動產生。

## 連線及檔案設定
連線相關設定（IP、COM Port）在「[Contest\Configuration.cs](/Contest/Configuration.cs)」中，設定錯誤會造成無法連線。

檔案及路徑相關設定也在同一份檔案中。

# 版本及兼容性
- HRSDK：2.2.9_7492
- HRSS：3.3.11.7492
- Android App：[nfu-irs-lab/hiwinrobot-controller-app](https://github.com/nfu-irs-lab/hiwinrobot-controller-app) 版本 [v1.0.0](https://github.com/nfu-irs-lab/hiwinrobot-controller-app/releases/tag/v1.0.0)

# 其它資源
- HIWIN 相關文件：[nfu-irs-lab/documents/hiwin.md](https://github.com/nfu-irs-lab/documents/blob/main/others/hiwin.md)
