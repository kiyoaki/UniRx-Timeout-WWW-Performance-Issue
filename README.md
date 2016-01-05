WWWを使用したGETやPOSTのTimeout時、yield return wwwで待機している場合は問題無いが、yield return nullで待機させているコルーチンはTimeout直後のフレームで処理が重たくなる様子。

【環境】
Unity5.1.4f1 EditorとAndroid（iOS IL2CPPでは発生しない様子）

## プロファイラー

![プロファイラー](https://raw.githubusercontent.com/kiyoaki/UniRx-Timeout-WWW-Performance-Issue/master/Images/Profiler.PNG "プロファイラー")
