using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData_New", menuName = "GameData")]
public class SO_Gamedata : ScriptableObject, ISerializationCallbackReceiver
{
    public int playerMoral = 700;
    public int playerSuprimentos = 3;

    void ISerializationCallbackReceiver.OnAfterDeserialize()
    {
        playerMoral = 700;
        playerSuprimentos = 3;
    }

    void ISerializationCallbackReceiver.OnBeforeSerialize()
    { }
}
