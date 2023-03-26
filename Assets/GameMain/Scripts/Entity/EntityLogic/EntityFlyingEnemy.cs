namespace Flower
{
    public class EntityFlyingEnemy : EntityEnemy
    {

        protected override void AddFsmState()
        {
            stateList.Add(FlyingEnemyMoveState.Create());
            stateList.Add(FlyingEnemyPushingThroughState.Create());
            stateList.Add(EnemyAttackHomeBaseState.Create());
        }

        protected override void StartFsm()
        {
            fsm.Start<FlyingEnemyMoveState>();
        }
    }
}
