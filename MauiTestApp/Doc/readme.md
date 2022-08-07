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

    dotnet workload install maccatalyst

