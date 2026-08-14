using Interface;
using UnityEngine;

namespace Component.Player
{
    public class PlayerRunState : IPlayerState
    {
        public void EnterState(PlayerController player)
        {
            Debug.Log("Entered PlayerRunState");
        }

        public void UpdateState(PlayerController player)
        {
          float moveInput = Input.GetAxisRaw("Horizontal");
          
          /*player.transform.Translate(Vector3.right
                                     * moveInput * Time.deltaTime);*/
          // tac dung 1 luc vay nhan vat, va đẩy nhân vật đi 
          player.rigidBody.linearVelocity = new Vector2(moveInput * player.speed
              , player.rigidBody.linearVelocity.y);
          
          
          if (moveInput == 0)
          {
              player.ChangeState(player.idleState);
          }
          
          if(Input.GetKeyDown(KeyCode.Space) )
          {
              player.ChangeState(player.jumpState);
          }
          
        }

        public void ExitState(PlayerController player)
        {
          Debug.Log("Exited PlayerRunState");
        }
    }
}