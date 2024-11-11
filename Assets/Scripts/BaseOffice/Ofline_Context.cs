namespace BombOffline
{
    public class Offline_Context
    {
        public static ConfirmBox Confirm
        {
            get
            {
                return ConfirmBox.Setup();
            }
        }

        public static WaitingBox Waitting
        {
            get
            {
                return WaitingBox.Setup();
            }
        }
    }
}
