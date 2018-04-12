using UnityEngine;

namespace Assets
{
    class PlayerMovingDirectionGetter : MovingDirectionGetter
    {
        public override EnumMoveDirection Get()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                return EnumMoveDirection.LEFT;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                return EnumMoveDirection.RIGHT;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                return EnumMoveDirection.UP;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                return EnumMoveDirection.DOWN;
            }
            return EnumMoveDirection.NEUTRAL;
        }
    }
}
