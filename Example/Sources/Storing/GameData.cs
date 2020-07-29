﻿using UnityEngine;

namespace CeresECL.Example
{
    [CreateAssetMenu(fileName = "GameData", menuName = "Insane ECL/Example/Game Data")]
    public class GameData : ScriptableObject
    {
        public GameObject PlayerPrefab;
        public GameObject BulletPrefab;
    }
}