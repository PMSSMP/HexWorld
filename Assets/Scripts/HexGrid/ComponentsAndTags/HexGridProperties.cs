using Unity.Entities;
using UnityEngine;

namespace HexGrid
{
    public struct HexGridProperties : IComponentData
    {
        public Entity HexCellPrefab;
    }
}