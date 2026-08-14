using Interface;
using Unity.VisualScripting;
using UnityEngine;

namespace Component.Player
{
    public class PlayerIdleState : IPlayerState
    {
        public void EnterState(PlayerController player)
        {
            Debug.Log("Entered PlayerIdleState");
        }

        public void UpdateState(PlayerController player)
        {
            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                player.ChangeState(player.runState);
            }
            
            if(Input.GetKeyDown(KeyCode.Space) )
            {
                player.ChangeState(player.jumpState);
            }
        }

        public void ExitState(PlayerController player)
        {
          Debug.Log("Exited PlayerIdleState");
        }
    }
}