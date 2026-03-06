using Inspector;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Button(parameters: 13)]
    [Button(parameters: 54)]
    void Hoge(int i)
    {
        Debug.Log(i);
    }
}
