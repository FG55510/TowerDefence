using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData_New", menuName = "GameData")]
public class SO_Gamedata : ScriptableObject, ISerializationCallbackReceiver
{
    public int playerMoral = 1500;
    public int playerSuprimentos = 3;

    void ISerializationCallbackReceiver.OnAfterDeserialize()
    {
        playerMoral = 1500;
        playerSuprimentos = 3;
    }

    void ISerializationCallbackReceiver.OnBeforeSerialize()
    { }
}
