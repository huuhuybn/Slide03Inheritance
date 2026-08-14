using Interface;
using UnityEngine;

namespace Component.Player
{
    public class PlayerJumpState : IPlayerState
    {
        public void EnterState(PlayerController player)
        {
            Debug.Log("Entered PlayerJumpState");
            player.rigidBody.linearVelocity = new Vector2( player.rigidBody.linearVelocity.x,
               player.jumpForce);

        }

        public void UpdateState(PlayerController player)
        {
            float moveInput = Input.GetAxisRaw("Horizontal");
            player.rigidBody.linearVelocity = new Vector2(moveInput * player.speed
                , player.rigidBody.linearVelocity.y);
            
            // kiểm tra nhân vật đã chạm đất chưa 
            if (player.rigidBody.linearVelocity.y <= 0.01f && player.rigidBody.linearVelocity.y >= -0.01f)
            {
                if (moveInput != 0)
                {
                    player.ChangeState(player.runState);
                }
                else
                {
                    player.ChangeState(player.idleState);
                }
            }
          
        }

        public void ExitState(PlayerController player)
        {
          Debug.Log("Exited PlayerRunState");
        }
    }
}