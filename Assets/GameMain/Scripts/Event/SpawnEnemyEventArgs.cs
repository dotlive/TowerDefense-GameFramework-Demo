using GameFramework.Event;
using GameFramework;

namespace Flower
{
    public class SpawnEnemyEventArgs : GameEventArgs
    {
        public static readonly int EventId = typeof(SpawnEnemyEventArgs).GetHashCode();

        public int EnemyId
        {
            get;
            private set;
        }

        public SpawnEnemyEventArgs()
        {
            EnemyId = -1;
        }

        public override int Id
        {
            get
            {
                return EventId;
            }
        }

        public static SpawnEnemyEventArgs Create(int enemyID, object userData = null)
        {
            SpawnEnemyEventArgs SpawnEnemyEventArgs = ReferencePool.Acquire<SpawnEnemyEventArgs>();
            SpawnEnemyEventArgs.EnemyId = enemyID;
            return SpawnEnemyEventArgs;
        }

        public override void Clear()
        {
            EnemyId = -1;
        }
    }

}
