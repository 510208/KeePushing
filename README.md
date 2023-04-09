# KeePushing

___

## 腳本編寫說明

- 此為Windwos SendKeys腳本，可以作為程式碼使用
* 如果需要模擬輸入文字，可以直接輸入該文字
* 如果需要模擬輸入快速鍵，可參照下表進行輸入：

| 特殊按鍵 | 說明 |
| -------- | ---- |
| {ENTER}  | 傳送 ENTER 鍵 |
| {TAB}    | 傳送 TAB 鍵 |
| {ESC}    | 傳送 ESC 鍵 |
| {BACKSPACE} 或 {BKSP} | 傳送 BACKSPACE 鍵 |
| {DELETE} | 傳送 DELETE 鍵 |
| {HOME}   | 傳送 HOME 鍵 |
| {END}    | 傳送 END 鍵 |
| {PGUP} 或 {PGDN} | 傳送 PAGE UP 或 PAGE DOWN 鍵 |
| {UP}、{DOWN}、{LEFT} 或 {RIGHT} | 傳送方向鍵 |
| {INSERT} 或 {INS} | 傳送 INSERT 鍵 |
| {F1} 到 {F24} | 傳送功能鍵 |
| {CAPSLOCK}、{NUMLOCK} 或 {SCROLLLOCK} | 傳送鎖定鍵狀態 |
| {PRINTSCREEN} | 傳送 PRINT SCREEN 鍵 |
| {{} 或 {}} | 傳送 { 或 } 字元本身 |

## 腳本範例

想模擬輸入"企鵝哥"並模擬按下Enter鍵，語法如下：

``` VB
企鵝哥{ENTER}
```

想模擬連續按方向左右鍵2次，可以如下：

``` VB
{LEFT}{RIGHT}{LEFT}{RIGHT}
```

想模擬先連續按BACKSPACE兩次後再連續按TAB3次，如下：

``` VB
{BKSP 2}{TAB 3}
```

或

``` VB
{BACKSPACE 2}{TAB 3}
```

> 如果想協助別人使用更多設定檔，可以在Wiki提交，連結：[點我看看](https://github.com/510208/KeePushing/discussions/2)
