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
1. 更新確認画面が出ます。新しいものが出ていれば最新のものに変えることを推奨します。
<br>![medialogger-01](https://user-images.githubusercontent.com/50388614/87239534-21fc5e00-c44b-11ea-939d-2dc3c0de8abc.gif)
1. 画面左上にあるキー設定を変えられます。デフォルトのままでも問題はないと思いますが、もし他のアプリケーションのショートカットキーにもなっていたなら、被らない別のキーにしましょう。ちなみにこの画面でも設定されたキーを押されたか確認ができます。
<br>![medialogger-02](https://user-images.githubusercontent.com/50388614/87239610-1a898480-c44c-11ea-832c-06d09b84c5ea.gif)
1. 画面中央にある監視ディレクトリを指定します。ここでは『どこのディレクトリのファイル生成をトリガーにするか』を選択できます。ちなみに指定したディレクトリだけでなく、それより下層のサブディレクトリも生成検知が可能です。
1. 画面下にある効果音を指定します。この効果音はログを取得する際に鳴らす効果音のことを指します。効果音はWave,mp3,m4a,aac,flac,midi等のWMPで再生できるもの全てに対応しています。
1. 下のボリュームコントロールで音量を調整しましょう。音量を0にすると効果音ファイルを指定しなくても監視を始めることができます。(監視ディレクトリを指定している場合に限り)
<br>![medialogger-03](https://user-images.githubusercontent.com/50388614/87239679-de0a5880-c44c-11ea-8be0-723d609683b4.gif)
1. 以上、設定が正常に完了している場合、右下の開始ボタンが有効化しています。押せない場合は上記のどこかに不足事項があります。

## 使い方

1. 開始ボタンを押します。押すとバルーン通知(Win10の場合はアクションセンター通知)が表示されます。
<br>![medialogger-04](https://user-images.githubusercontent.com/50388614/87240616-fd59b380-c455-11ea-849a-54bb36baf153.gif)
1. 監視ディレクトリ先でファイルを生成してください。(キャプチャーの場合は収録開始、ボイスレコーダーの場合は録音開始)
1. ファイル生成を検知した場合、バルーン通知にてログ記録を開始した旨のメッセージが表示されます。
<br>![medialogger-08](https://user-images.githubusercontent.com/50388614/87240965-38a9b180-c459-11ea-8142-5e604a5b372f.gif)
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
<br>![medialogger-09](https://user-images.githubusercontent.com/50388614/87241227-c8505f80-c45b-11ea-8229-8c1867de81b9.gif)
1. バルーン通知で記録を停止した旨のメッセージが表示されます。

## 終了方法

1. タスクトレイにあるMediaLoggerアイコンを右クリック
1. 終了をクリック

## 更新確認

1. タスクトレイにあるMediaLoggerアイコンを右クリック
1. 更新をクリック。最新バージョンを確認します。

## 報告

バグを発見した場合はお手数をおかけしますが、issuesからご一報頂けると幸いです。

## 協力

アイコン写真提供：Ecru
