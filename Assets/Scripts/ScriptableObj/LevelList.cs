using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.ScriptableObj
{
    [CreateAssetMenu(fileName = "LevelsList", menuName = "Configs/LevelsList", order = 0)]
    public class LevelList : ScriptableObject
    {
        public GameObject[] Levels;
    }
}
