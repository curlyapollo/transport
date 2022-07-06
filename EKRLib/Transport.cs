using System.Linq;

namespace EKRLib
{
    /// <summary>
    /// Базовый абстрактный класс для любого транспорта.
    /// </summary>
    public abstract class Transport
    {
        private string _model;

        /// <summary>
        /// Свойство, определяющее модель транспорта.
        /// </summary>
        /// <exception cref="TransportException">Исключение при неверном вводе модели.</exception>
        public string Model
        {
            get => _model;
            set
            {
                if (value.Length != 5 || !value.ToCharArray().All(x =>
                        (x >= 'A' && x <= 'Z') || (x >= '0' && x <= '9')))
                {
                    throw new TransportException($"Недопустимая модель {value}");
                }

                _model = value;
            }
        }

        private uint _power;

        private uint Power
        {
            get => _power;
            set
            {
                if (value < 20)
                {
                    throw new TransportException("Мощность не может быть меньше 20 л.с.");
                }

                _power = value;
            }
        }

        /// <summary>
        /// Переопределение метода Tostring().
        /// </summary>
        /// <returns>Строковый вид экземпляра.</returns>
        public override string ToString() => $"Model: {Model}, Power: {Power}";

        /// <summary>
        /// Базовый метод включения транспорта.
        /// </summary>
        /// <returns>Звук транспорта.</returns>
        public abstract string StartEngine();

        protected Transport(string model, uint power)
        {
            Model = model;
            Power = power;
        }
    }
}