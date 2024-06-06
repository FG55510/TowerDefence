using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData_New", menuName = "GameData")]
public class SO_Gamedata : ScriptableObject, ISerializationCallbackReceiver
{
    public int playerMoral = 500;
    public int playerSuprimentos = 3;

    void ISerializationCallbackReceiver.OnAfterDeserialize()
    {
        playerMoral = 500;
        playerSuprimentos = 3;
    }

    void ISerializationCallbackReceiver.OnBeforeSerialize()
    { }
}
