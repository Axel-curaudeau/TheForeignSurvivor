using System.Collections.Generic;

namespace Assets.Scripts.player
{
    public sealed class Player
    {
        private string name { get; set; }
        private int health { get; set; }
        private int maxHealth { get; set; }
        private float speed { get; set; }
        private int score { get; set; }

        private List<Weapon> inventory { get; }

        private static Player instance = null;

        public static Player GetInstance {
            get {
                if (instance == null) {
                    instance = new Player();
                }
                return instance;
            }
        }

        private Player(string name = "Player", int health = 20, int maxHealth = 20, float speed = 10f, int score = 0)
        {
            this.name = name;
            this.health = health;
            this.maxHealth = maxHealth;
            this.speed = speed;
            this.score = score;

            inventory = new List<Weapon>();
        }
    }
}
