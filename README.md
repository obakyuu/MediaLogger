# MediaLogger
<a href="https://github.com/obakyuu/MediaLogger/blob/master/LICENSE"><img alt="GitHub license" src="https://img.shields.io/github/license/obakyuu/MediaLogger"></a>
<a href="https://github.com/obakyuu/MediaLogger/issues"><img alt="GitHub issues" src="https://img.shields.io/github/issues/obakyuu/MediaLogger"></a>
<a href="https://github.com/obakyuu/MediaLogger/network"><img alt="GitHub forks" src="https://img.shields.io/github/forks/obakyuu/MediaLogger"></a>
<a href="https://github.com/obakyuu/MediaLogger/stargazers"><img alt="GitHub stars" src="https://img.shields.io/github/stars/obakyuu/MediaLogger"></a><br>
## MediaLoggerとは？

- このアプリは動画収録時に『後でこのシーンを動画に使いたいな...』と思った時、収録開始時からの経過時間を手動でログファイルに出力する動画編集者を支援するアプリケーションです。
- このアプリは会議の時に『後で会話を振り返りたいな...』と思った時、録音開始時からの経過時間を手動でログファイルに出力するアプリです。

> 実際、使い方は様々です。ユーザのお好みでどうぞ。

## 要約
 
このアプリは『ファイル生成』をトリガーにタイマーが作動、あとは任意のキーを押すことで時間を記録するアプリです。
 
## 動作環境

- Windows NT系OS
  - 推奨: Windows 8 / 8.1 / 10（ビット問わず）
  - 未検証: Windows 7 / Vista / XP / 2k（ビット問わず）
  - 不可(?): Windows 2k以前のOS（9x系、Me）

## 動作確認ソフト

- GeForceExperience Share
- OBS
- アマレコTV Live アマミキ！
- ボイスレコーダー

## できないこと

- 生配信などの<b>ローカルにファイルが生成されないもの</b>
- ハードウェアエンコードなどの<b>PCを介さず、単体で記憶デバイスに保存されるもの</b>

## 起動方法

『MediaLogger.exe』を起動するだけです。

## 削除方法

フォルダごと削除してください。

## 使用準備

1. MediaLoggerを起動
1. 更新確認画面が出ます。（新しいものが出ていれば最新のものに変えることを推奨します。）
![000](https://user-images.githubusercontent.com/50388614/91619861-48f5fb80-e9c9-11ea-971d-d3c5afa28756.gif)
1. 画面左上にあるキー設定を変えられます。キーバインド方式を採用しており指定時間内に入力されたキーを設定します。他のアプリケーションのショートカットキーと被る可能性もありますので被らないキーに設定しましょう。
![001](https://user-images.githubusercontent.com/50388614/91619863-4dbaaf80-e9c9-11ea-8eb5-3158746b5fe9.gif)
1. 画面中央にある監視ディレクトリを指定します。ここでは『どこのディレクトリのファイル生成をトリガーにするか』を選択できます。ちなみに指定したディレクトリだけでなく、それより下層のサブディレクトリも生成検知が可能です。
1. 画面下にある効果音を指定します。この効果音はログを取得する際に鳴らす効果音のことを指します。効果音はWave,mp3,m4a,aac,flac,midi等のWMPで再生できるもの全てに対応しています。
1. 下のボリュームコントロールで音量を調整しましょう。音量を0にすると効果音ファイルを指定しなくても監視を始めることができます。(監視ディレクトリを指定している場合に限り)
![002](https://user-images.githubusercontent.com/50388614/91619865-4f847300-e9c9-11ea-97e4-55edfa84f5b7.gif)
1. 以上、設定が正常に完了している場合、右下の開始ボタンが有効化しています。押せない場合は上記のどこかに不足事項があります。
1. 初期化をしたい場合は、メニューストリップからメニュー→初期化を押すことで初期状態へ戻せます。
![005](https://user-images.githubusercontent.com/50388614/91619872-53b09080-e9c9-11ea-8785-2412bf53efdd.gif)

## 使い方

1. 開始ボタンを押します。押すとバルーン通知(Win10の場合はアクションセンター通知)が表示されます。
![003](https://user-images.githubusercontent.com/50388614/91619866-50b5a000-e9c9-11ea-9de1-6209e9bed248.gif)
1. 監視ディレクトリ先でファイルを生成してください。(キャプチャーの場合は収録開始、ボイスレコーダーの場合は録音開始)
1. ファイル生成を検知した場合、バルーン通知にてログ記録を開始した旨のメッセージが表示されます。
![004](https://user-images.githubusercontent.com/50388614/91619868-51e6cd00-e9c9-11ea-94bf-e294ae807142.gif)
1. あとは任意のタイミングで先ほど指定したキーを押しましょう。押すと効果音が鳴ります。（音量を0にしていなければ）タスクアイコンが一瞬だけ赤くなります。
<br>![medialogger-06](https://user-images.githubusercontent.com/50388614/87240808-da300380-c457-11ea-9669-d9c7bf91f09d.gif)

## どこにログが保存される？

ログはトリガーとなったファイルと同じディレクトリに保存されます。（キャプチャーの場合は動画ファイル保存先、ボイスレコーダーの場合は音声ファイル保存先）ファイル名はファイル生成を検知した瞬間の年月日と時間がファイル名となっています。

## 停止方法

停止方法は2つあります。

> トリガーファイルから停止する
1. トリガーとなったファイルに何らかの更新を加えてください（キャプチャーの場合は動画保存。ボイスレコーダーの場合は録音停止）
<br>![medialogger-07](https://user-images.githubusercontent.com/50388614/87240892-85d95380-c458-11ea-8cda-997fab2825bd.gif)
1. 正常に更新検知をすると、自動でバルーン通知で記録を停止した旨のメッセージが表示されます。
> 手動で停止する
1. 設定画面が表示されていない場合、タスクアイコンからMediaLoggerを右クリック、設定をクリックすると先ほどの画面が表示されます。（もしくはMediaLoggerをダブルクリックでも表示できます。）
1. 画面右下に停止ボタンがあるので停止をクリック。
![009](https://user-images.githubusercontent.com/50388614/91619881-59a67180-e9c9-11ea-88e7-9012db842052.gif)
1. バルーン通知で記録を停止した旨のメッセージが表示されます。

## 終了方法

1. タスクトレイにあるMediaLoggerアイコンを右クリック
1. 終了をクリック
<br>![008](https://user-images.githubusercontent.com/50388614/91619880-58754480-e9c9-11ea-90ca-f8df8efda8f5.gif)

## 更新確認

1. タスクトレイにあるMediaLoggerアイコンを右クリック
1. 更新をクリック。最新バージョンを確認します。

## 報告

バグを発見した場合はお手数をおかけしますが、issuesからご一報頂けると幸いです。

## 協力

アイコン写真提供：Ecru
