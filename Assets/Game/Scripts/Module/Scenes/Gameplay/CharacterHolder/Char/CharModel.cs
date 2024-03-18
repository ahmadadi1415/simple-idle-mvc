using System;
using Agate.MVC.Base;
using Random = UnityEngine.Random;

namespace SimpleIdle.Gameplay.Character
{
    public class CharModel : BaseModel, ICharModel
    {
        public string Name { get; private set; }
        public int Stamina { get; private set; }
        public int Hunger { get; private set; }
        public int Thirst { get; private set; }
        public int Temperature { get; private set; }

        public CharModel()
        {
            SetStamina(Random.Range(0, 100));
            SetThirst(Random.Range(0, 100));
            SetTemperature(Random.Range(35, 37));
            SetHunger(Random.Range(0, 100));
            SetDataAsDirty();
        }

        public void SetName(string name)
        {
            Name = name;
            SetDataAsDirty();
        }

        public void SetHunger(int hunger)
        {
            Hunger = hunger;
            SetDataAsDirty();
        }

        public void ReduceHunger(int reducedHunger)
        {
            if (Hunger <= 100)
            {
                Hunger = Math.Clamp(Hunger -= reducedHunger, 0, 100);
            };
            SetDataAsDirty();
        }

        public void IncreaseHunger(int increasedHunger)
        {
            if (Hunger >= 0)
            {
                Hunger = Math.Clamp(Hunger += increasedHunger, 0, 100);
            }
            SetDataAsDirty();
        }

        public void SetThirst(int thirst)
        {
            Thirst = thirst;
            SetDataAsDirty();
        }

        public void ReduceThirst(int reducedThirst)
        {
            if (Thirst <= 100)
            {
                Thirst = Math.Clamp(Thirst -= reducedThirst, 0, 100);
            }
            SetDataAsDirty();
        }

        public void IncreaseThirst(int increasedThirst)
        {
            if (Hunger >= 0)
            {
                Thirst = Math.Clamp(Thirst += increasedThirst, 0, 100);
            }
            SetDataAsDirty();
        }

        public void SetStamina(int stamina)
        {
            Stamina = stamina;
            SetDataAsDirty();
        }

        public void AddStamina(int stamina)
        {
            if (Stamina <= 100)
            {
                Stamina = Math.Clamp(Stamina += stamina, 0, 100);
            };
            SetDataAsDirty();
        }

        public void ReduceStamina(int stamina)
        {
            if (Stamina >= 0)
            {
                Stamina = Math.Clamp(Stamina -= stamina, 0, 100);
            };
            SetDataAsDirty();
        }

        public void SetTemperature(int temperature)
        {
            Temperature = temperature;
            SetDataAsDirty();
        }

    }
}