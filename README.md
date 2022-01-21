# Robotic Arm Control Panel

[![GitHub release](https://img.shields.io/github/release/nfu-irs-lab/robotic-arm-control-panel.svg)](https://github.com/nfu-irs-lab/robotic-arm-control-panel/releases)
[![GitHub issues](https://img.shields.io/github/issues/nfu-irs-lab/robotic-arm-control-panel.svg)](https://github.com/nfu-irs-lab/robotic-arm-control-panel/issues)

手臂控制面板。

---

# 使用方法及問題解決
執行時可能會遇到一些問題，此時請參考以下各事項。

## HRSDK.dll
> 發生例外「System.DllNotFoundException」並提示無法載入「HRSDK.dll」時可以嘗試。

請將正確版本的「HRSDK.dll」檔案放在目前程式執行的工作路徑下，例如：`ExclusiveProgram\bin\x64\Debug\`。

工作路徑會因 Visual Studio 的編譯及執行設定不同而改變，例如「Any CPU」、「x86」、「x64」和「Debug」、「Release」。

## 設定起始專案
> 提示「A project with an Output Type of Class Library cannot be started directly.」時可以嘗試。

1. 以 Visual Studio 開啓 Solution 檔 「[RoboticArm.sln](/RoboticArm.sln)」。
2. 在 Visual Studio 的「Solution Explorer」中，對 Project「ExclusiveProgram」點擊滑鼠右鍵。
3. 點選右鍵清單中的「Set as Startup Project」。

## NuGet Packages
> 提示「無法找到 NuGet Packages」時可以嘗試。

1. 以 Visual Studio 開啓 Solution 檔 「[RoboticArm.sln](/RoboticArm.sln)」。
2. 在 Visual Studio 的「Solution Explorer」中，對本 Solution「Solution 'RoboticArm'」點擊滑鼠右鍵。
3. 點選右鍵清單中的「Restore NuGet Packages」，並等待其完成。
4. 確認資料夾「packages」及其內容已經於 Solution 路徑下自動產生。

## MainForm 資料夾沒有檔案

1. 使用 git 指令更新 submodule：`git submodule update --init --recursive`。

## Git Clone

- 因爲本 repo 含有 [submodule](https://git-scm.com/book/en/v2/Git-Tools-Submodules)，在使用 `git clone` 指令時，請再加上 `--recurse-submodules`，也就是 `git clone --recurse-submodules https://github.com/nfu-irs-lab/robotic-arm-control-panel.git`。
- 如果在使用 `git clone` 指令時忘記加上 `--recurse-submodules` 的話，只要再執行 `git submodule update --init --recursive` 指令即可。

