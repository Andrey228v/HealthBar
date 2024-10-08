using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Service.Health
{
    public class HealthSystem : MonoBehaviour, IHealth
    {
        [SerializeField] private int _maxHealth;
        [SerializeField] private int _health;
        
        public event Action isDead;
        public event Action isHealed;
        public event Action isDamaged;

        public int MaxHealth { get; private set; }

        public int HealthAmount { get; private set; }

        private void Awake()
        {
            MaxHealth = _maxHealth;
            HealthAmount = _health;
        }

        private void Start()
        {
            isHealed?.Invoke();
        }

        public void GetDamage(int damage)
        {
            _health -= damage;

            if (_health < 0)
            {
                _health = 0;
            }

            if (_health == 0)
            {
                isDead?.Invoke();
            }

            HealthAmount = _health;
            isDamaged?.Invoke();
        }

        public bool TryGetHealth(int healthPoints)
        {
            bool isTake = false;

            if (_health < _maxHealth)
            {
                _health += healthPoints;
                isTake = true;

                if (_health > _maxHealth)
                {
                    _health = _maxHealth;
                }

                HealthAmount = _health;
                isHealed?.Invoke();
            }

            return isTake;
        }
    }
}
