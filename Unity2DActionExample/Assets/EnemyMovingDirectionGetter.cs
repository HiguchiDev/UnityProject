using UnityEngine;

namespace Assets
{
    class EnemyMovingDirectionGetter : MovingDirectionGetter
    {
        public override EnumMoveDirection Get()
        {
            int moveDirectionNum =  UnityEngine.Random.Range(1, (int)EnumMoveDirection.MAX);

            switch (moveDirectionNum)
            {
                case (int)EnumMoveDirection.LEFT:
                        return EnumMoveDirection.LEFT;
                case (int)EnumMoveDirection.RIGHT: 
                        return EnumMoveDirection.RIGHT;
                case (int)EnumMoveDirection.UP:
                    return EnumMoveDirection.UP;
                case (int)EnumMoveDirection.DOWN:
                    return EnumMoveDirection.DOWN;
                default:
                    return EnumMoveDirection.NEUTRAL;
            }
        }
    }
}
