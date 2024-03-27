# UnityGameObjectStateSwitchTimelineTrack
GameObjectステート状態を切り替えるカスタムトラックの表示例

![image](https://lh3.googleusercontent.com/pw/AP1GczPMc22SA8QqMBJx3JJ075BDYUzZBJMzJtcETHfq_P3n_gYuIh2fDoBRvB3FXqmvSwPvmYTtMaulEF0uSn5ZngXAtc1jlZivGbVpJR83YniYMoEoApb-M32nm8pfHdC-kt4JQB_FtxVRS5qSqmoQGQUW=w945-h111-s-no-gm?authuser=0)


# 特徴
Unitiyタイムラインにて任意のゲームオブジェクトをアクティブ非アクティブとして切り替えるトラックのサンプルプロジェクトです．
- TImelineにカスタムトラックを追加します．
- 任意のゲームオブジェクトのステート状態をアクティブ，非アクティブにします．
- クリップ再生時とそれ以外のときでステート状態を選択できます．
- カットシーンの作成など画面構成を変更したいが，ゲームオブジェクトを消したくないときなどに使用してください．


# インストール方法
1. Releasesより最新のUnityPackagesをダウンロードする．
2. Asset > Import Pakages > Custom Pakege より1のパッケージをインポートする．
3. UnityEditorを再起動する．
4. AssetフォルダにCustomTimelineフォルダが生成されていることを確認する．


# 使い方
1. ”Game Object State Switch Track”というトラックを追加する．
2. 1のトラックにてクリップを追加する．
3. クリップのInspector内のGame Object StateにてActiveかInactiveのいずれかを選択する．
4. トラックのInspector内のDefoult Game Object StateをActive，Inactiveのいずれかを選択する．

## Inspectorの表示について
クリップとタイムラインのInspector表示についてまとめます．

クリップ

![image](https://lh3.googleusercontent.com/pw/AP1GczPc9W1Q4zCPTTcsH22K-cTnuPRi3s1FRJvWUs0rDKWeciXQA1-LHssZnjDmez6_rltQ0N2sOPOa4iowg6Pv0ZFdVGFLnKJD7ba0hnKKnMZEhFldfDqos4jZP_Y_iV5NcVs0uaor_rjZ1xasWwdWUzN9=w413-h261-s-no-gm?authuser=0)

トラック

![image](https://lh3.googleusercontent.com/pw/AP1GczPQJ1KvD1GXwZtieCTTMAsA0Jfl3jdxEJ2JUBzROBeDiENsDTXxdrmiTv0WejBfLrcp3ln3_bU7IFPR0KdncvjWy-fxUJxXoxbjuSlxHPdfUmjY3qNsasb3XTKUKhGBWO0bB9-yrrpLDpBu-8TL3ShU=w411-h167-s-no-gm?authuser=0)

## Active，Inactiveについて
Active：GameObjectのステート状態をアクティブにします．

![image](https://lh3.googleusercontent.com/pw/AP1GczMMpsdWq_kttxq2IXeNyWa94xZqLmr55y4NolP02L9ipYhdpRIadMF5K75rscpKdIhk-lomy_XXakOTzQIrpawIR6KLpxiOh3vjizVQnEx1AsxCpljwqYHYXKtpN8DZ2vek3goxdDgyEWQmkijdBSbH=w125-h125-s-no-gm?authuser=0)

Inactive：GameObjectのステート状態を非アクティブにします．

![image](https://lh3.googleusercontent.com/pw/AP1GczNMSZv1egu2Uy8YiF7di9N1XjHy_fYJguK3LjaFO0ZwjozcWtRrbY5MN94WvNhh2Sss7XTo4Cbjag8qfM_qfTfIoKe2v6nhYmdBc2FXn66dqLxeVCWIVmbAP9Ahe3N7b2rlCoDh0SR4-M9blIZ06KJU=w123-h123-s-no-gm?authuser=0)



