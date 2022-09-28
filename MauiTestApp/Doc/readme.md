# MAUIアプリ開発

## .Net MAUIについて
Xamarinの進化系

## 対応プラットフォーム
Android、iOS、macOS、Windows(Linuxは対象外)

## 各プラットフォームでのコンパイル＆実行方法
Android：(コンパイル)C#→IL　　→　(実行) IL→(JIT)→ネイティブ
iOS：(コンパイル&実行)C#→ARMアセンブリコード
macOS：(コンパイル)C#→ARMアセンブリコード　(実行)Mac Catalyst・・・UIKit で構築された iOS アプリをデスクトップに導入
Windows：(コンパイル&実行)C#→ネイティブコード　（WindowsUI3）

*iOS および macOS 用のアプリをビルドするには、Mac が必要。

## 使用言語
C# & XAML

## Xamarinと異なる点
| 項目             | Xamarin                       | MAUI                 |
| -------------- | ----------------------------- | -------------------- |
| プロジェクトの数       | 4(各OSのプロジェクト数)＋1(Formsプロジェクト) | 1                    |
| プラットフォーム固有のコード | DependencyService^1           | プラットフォームごとに実装したコード^2 |
| ツールチェーン        | .NET Framework                | .NET CLI             |
| 画像リソース           | 画像などプラットフォームごとに個別管理                              |     SVGファイルなら各プラットフォームごとの解像度のPNGに変換可能                 |
|  UIコントロールアーキテクチャ              |     レンダラー                          |     ハンドラー                 |
|                |                               |                      |

[^1] DependencyServiceでIPlatformInfoを継承し、OSごとに別々の実装をする
https://atmarkit.itmedia.co.jp/ait/articles/1610/12/news021.html
[^2] 1つのメソッドを呼び出すときに、AndroidならAndroid.Contentを使用して実行、iOSならUIKitを使用するなどOSに合わせたコードを記述可能
https://learn.microsoft.com/ja-jp/dotnet/maui/platform-integration/invoke-platform-code

## UIコントロールアーキテクチャ　レンダラーとハンドラーの違い

| 項目  | レンダラー    | ハンドラー    |
| --- | --- | --- |
|  UIとの結合   | 密結合    | 疎結合    |
|  処理速度   |  遅い   |  速い   |
|  コード変更に対する生産コスト   | 高(定型的な多くのコードを記述する必要あり)    |  低   |

RendererがUIと直接依存
![Renderer](.\Picture/XamarinRender.png)

間にインターフェースを挟むため、依存関係がない。
![Handler](.\Picture/MAUIHandler.png)

https://atmarkit.itmedia.co.jp/ait/articles/2207/28/news003.html

## デバッグ

### Windows

Windowsでデバッグするためには開発者モードを有効にする必要がある．

![WindowsDebug1](.\Picture/DebugWindows1.png)

![WindowsDebug2](.\Picture/DebugWindows2.png)

![WindowsDebug3](.\Picture/DebugWindows3.png)

## トラブルシューティング

### maccatalystがないためビルドエラーになる

[現象]
ビルドを実行すると以下のエラーが発生する

![ビルドエラー](.\Picture/BuildError.png)

[原因]
必要なモジュールがインストールされていない

[解決策]
コマンドプロンプトで以下を実行

    cd <MAUIのプロジェクト>
    dotnet workload install maccatalyst

以下のエラーが出る場合、NugetPackageManagerを設定する

```
広告マニフェスト microsoft.net.sdk.android を更新できませんでした: ソース https://xxx のサービス インデックスを読み込めません。。
広告マニフェスト microsoft.net.sdk.ios を更新できませんでした: ソース https://xxx のサービス インデックスを読み込めません。。
広告マニフェスト microsoft.net.sdk.maccatalyst を更新できませんでした: ソース https://xxx のサービス インデックスを読み込めません。。
```

![NugetPackageManager](.\Picture\NugetPackageManager.png)