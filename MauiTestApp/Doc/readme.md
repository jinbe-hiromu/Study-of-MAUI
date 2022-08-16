# MAUI APP 開発

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