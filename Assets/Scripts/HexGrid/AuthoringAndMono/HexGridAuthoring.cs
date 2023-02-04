using Unity.Entities;
using UnityEngine;

namespace HexGrid
{
    public class HexGridAuthoring : MonoBehaviour
    {
        public GameObject HexGrid;
    }

    public class HexGridBaker : Baker<HexGridAuthoring>
    {
        public override void Bake(HexGridAuthoring authoring)
        {
            AddComponent(new HexGridProperties
            {
                HexCellPrefab = GetEntity(authoring.HexGrid)
            });
        }
    }
}