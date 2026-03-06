# Inspector
[![unity-meta-check](https://github.com/AndanteTribe/Inspector/actions/workflows/unity-meta-check.yml/badge.svg)](https://github.com/AndanteTribe/Inspector/actions/workflows/unity-meta-check.yml)
[![Releases](https://img.shields.io/github/release/AndanteTribe/Inspector.svg)](https://github.com/AndanteTribe/Inspector/releases)
[![GitHub license](https://img.shields.io/github/license/AndanteTribe/Inspector.svg)](./LICENSE)
[![openupm](https://img.shields.io/npm/v/jp.andantetribe.inspector?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/jp.andantetribe.inspector/)

English | [日本語](README_JA.md)

## Overview
**Inspector** is a Unity editor extension library that enhances Unity's built-in component inspectors with additional functionality.

- **TransformInspector** — Extends the Transform inspector to display world-space position, rotation, and scale directly in the Inspector window.
- **AnimatorInspector** — Extends the Animator inspector with additional fields: `Keep Animator State On Disable` and `Write Default Values On Disable`.
- **ButtonAttribute** — An attribute that adds a clickable button in the Inspector for any method, allowing you to invoke it directly from the editor.

## Requirements
- Unity 2021.3 or later

## Installation
Open `Window > Package Manager`, select `[+] > Add package from git URL`, and enter the following URL:

```
https://github.com/AndanteTribe/Inspector.git?path=src/Inspector.Unity/Packages/jp.andantetribe.inspector
```

## Features

### TransformInspector
Extends Unity's built-in Transform inspector to also show the world-space **Position**, **Rotation**, and **Scale** of the GameObject.

<img src="https://github.com/user-attachments/assets/3ac8f758-d1c1-43e6-99de-cdf85770e147">

### AnimatorInspector
Extends Unity's built-in Animator inspector with two additional toggle fields:
- **Keep Animator State On Disable** — Whether to preserve the AnimatorController state when the GameObject is disabled.
- **Write Default Values On Disable** — Whether to write default values when the Animator is disabled.

<img src="https://github.com/user-attachments/assets/1e5d1143-3787-4553-84ef-3d6705da2670">

### ButtonAttribute
Add a `[Button]` attribute to any method to display a clickable button in the Inspector. Supports passing arguments to the method.

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

## License
This library is released under the MIT license.
