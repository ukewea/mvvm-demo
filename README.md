# MVVM 範例

## 簡介

本範例使用 MVVM pattern，在 C# 中建立一個簡單的 WPF app。
該 app 展示了如何在不同的 View 顯示設備參數，以及如何使用 data binding 來保持 View 和 Model 之間的資料同步。

## Tech Stack

* C# (.NET 6)
* WPF (Windows Presentation Foundation)
* MVVM 架構

## 資料流

1. MainWindow 建立一個 ObservableCollection<DeviceParameter> 作為資料來源 (Model)。
2. MainWindow 將 Model 傳遞給 TableViewViewModel 和 BottomViewViewModel。
3. TableViewViewModel 將資料來源 binding 到 DataGrid 以在表格中顯示參數。
4. BottomViewViewModel 將資料來源 (Baud Rate 參數) 轉換為其他格式。
5. 當 Baud Rate 參數在上面的表格被修改時，TableViewViewModel 修改 Model 的內容。
6. Model 會告知 BottomViewViewModel 內容有更新。
7. BottomViewViewModel 更新其 BaudRateRange 屬性，觸發 View 的更新。

```
                MainWindow
              /            \
             /              \
            /                \
         DataGrid         BaudRateRange
         /                     \
    TableViewViewModel    BottomViewViewModel
          \                     /
           \                   /
            \                 /
             \               /
              \             /
               \           /
                 Parameter
```