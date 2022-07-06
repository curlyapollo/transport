using System;
namespace EKRLib
{
    /// <summary>
    /// Машина, наследуемая от транспорта.
    /// </summary>
    public class Car : Transport
    {
        /// <summary>
        /// Конструктор машины.
        /// </summary>
        /// <param name="model">Входная модель.</param>
        /// <param name="power">Входная мощность.</param>
        public Car(string model, uint power) : base(model, power)
        {
        
        }

        /// <summary>
        /// Переопределение метода ToString() для машины.
        /// </summary>
        /// <returns>Строковое представление машины.</returns>
        public override string ToString() => $"Car. {base.ToString()}";

        /// <summary>
        /// Переопределение метода включения для машины.
        /// </summary>
        /// <returns>Звук машины.</returns>
        public override string StartEngine() => $"{Model}: Vroom";
    }
}

