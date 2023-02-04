using UnityEngine;

namespace HexGrid
{
    [CreateAssetMenu(fileName = "HexGrid", menuName = "HexGrid", order = 0)]
    public class SO_HexGrid : ScriptableObject
    {
        public GameObject HexCellPrefab;
    }
}