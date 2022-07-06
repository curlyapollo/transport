namespace EKRLib
{
    /// <summary>
    /// Моторная лодка, наследуемая от транспорта.
    /// </summary>
    public class MotorBoat : Transport
    {

        /// <summary>
        /// Конструктор моторной лодки.
        /// </summary>
        /// <param name="model">Входная модель.</param>
        /// <param name="power">Входная мощность.</param>
        public MotorBoat(string model, uint power) : base(model, power)
        {

        }

        /// <summary>
        /// Переопределение метода ToString() для моторной лодки.
        /// </summary>
        /// <returns>Строковое представление моторной лодки.</returns>
        public override string ToString() => $"Motorboat. {base.ToString()}";

        /// <summary>
        /// Переопределение метода включения для машины.
        /// </summary>
        /// <returns>Звук машины.</returns>
        public override string StartEngine() => $"{Model}: Brrrbrr";
    }
}