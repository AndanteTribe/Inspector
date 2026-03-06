# Inspector
[![unity-meta-check](https://github.com/AndanteTribe/Inspector/actions/workflows/unity-meta-check.yml/badge.svg)](https://github.com/AndanteTribe/Inspector/actions/workflows/unity-meta-check.yml)
[![Releases](https://img.shields.io/github/release/AndanteTribe/Inspector.svg)](https://github.com/AndanteTribe/Inspector/releases)
[![GitHub license](https://img.shields.io/github/license/AndanteTribe/Inspector.svg)](./LICENSE)
[![openupm](https://img.shields.io/npm/v/jp.andantetribe.inspector?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/jp.andantetribe.inspector/)

[English](README.md) | 日本語

## 概要
**Inspector** は、Unityの組み込みコンポーネントインスペクターを拡張するエディター拡張ライブラリです。

- **TransformInspector** — Transformインスペクターを拡張し、ワールド空間の位置・回転・スケールをインスペクターウィンドウに表示します。
- **AnimatorInspector** — Animatorインスペクターに`Keep Animator State On Disable`と`Write Default Values On Disable`のフィールドを追加します。
- **ButtonAttribute** — メソッドに付与することで、インスペクターにボタンを表示し、エディター上から直接実行できるようにする属性です。

## 動作環境
- Unity 2021.3 以降

## インストール
`Window > Package Manager` を開き、`[+] > Add package from git URL` を選択して、以下のURLを入力してください：

```
https://github.com/AndanteTribe/Inspector.git?path=src/Inspector.Unity/Packages/jp.andantetribe.inspector
```

## 機能

### TransformInspector
Unityの標準Transformインスペクターを拡張し、GameObjectのワールド空間の**Position**・**Rotation**・**Scale**を追加表示します。

<img src="https://github.com/user-attachments/assets/3ac8f758-d1c1-43e6-99de-cdf85770e147">

### AnimatorInspector
Unityの標準Animatorインスペクターに、以下の2つのトグルフィールドを追加します：
- **Keep Animator State On Disable** — GameObjectが無効化された際にAnimatorControllerの状態を保持するかどうか。
- **Write Default Values On Disable** — Animatorが無効化された際にデフォルト値を書き込むかどうか。

<img src="https://github.com/user-attachments/assets/1e5d1143-3787-4553-84ef-3d6705da2670">

### ButtonAttribute
メソッドに`[Button]`属性を付与することで、インスペクターに実行ボタンを表示します。メソッドへの引数の受け渡しにも対応しています。

```csharp
using Inspector;
using UnityEngine;

public class Example : MonoBehaviour
{
    [Button("Sample1")]
    [Button("Sample2")]
    [Button("Sample3", 3)]
    void MyMethod(int value = 0)
    {
        Debug.Log(value);
    }
}
```

<img src="https://github.com/user-attachments/assets/a4c8a2cb-c329-4209-a069-d55db5f2618e">

## ライセンス
このライブラリはMITライセンスのもとで公開されています。
