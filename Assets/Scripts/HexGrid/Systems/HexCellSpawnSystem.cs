using Unity.Burst;
using Unity.Collections;
using Unity.Entities;

namespace HexGrid
{
    [BurstCompile]
    [UpdateInGroup(typeof(InitializationSystemGroup))]
    public partial struct HexCellSpawnSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<HexGridProperties>();
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        { 
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            state.Enabled = false;
            var hexGridEntity = SystemAPI.GetSingletonEntity<HexGridProperties>();
            var hexGrid = SystemAPI.GetAspectRO<HexGridAspect>(hexGridEntity);

            var ecb = new EntityCommandBuffer(Allocator.Temp);

            for (int i = 0; i < 100; i++)
            {
                ecb.Instantiate(hexGrid.HexCellPrefab);
            }
            
            ecb.Playback(state.EntityManager);
        }
    }
}