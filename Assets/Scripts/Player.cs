namespace DefaultNamespace
{
    public class Player
    {
        private int health = 100;
        private Inventory inventory;

        public void Heal()
        {
            health = 100;
        }

        public Inventory GetInventory()
        {
            return inventory;
        }
    }
}