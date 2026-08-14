namespace Interface
{
    public interface IPlayerState
    {
        // 3 HÀM TRẠNG THÁI CỦA NHÂN VẬT 
        void EnterState(PlayerController player);
        void UpdateState(PlayerController player);
        void ExitState(PlayerController player);
    }
}