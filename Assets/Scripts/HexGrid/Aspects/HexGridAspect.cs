using Unity.Entities;

namespace HexGrid
{
    public readonly partial struct HexGridAspect : IAspect
    {
        public readonly Entity Entity;

        private readonly RefRO<HexGridProperties> _hexGridProperties;

        public Entity HexCellPrefab => _hexGridProperties.ValueRO.HexCellPrefab;
    }
}