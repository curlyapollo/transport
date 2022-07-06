using System;
using System.Runtime.Serialization;

namespace EKRLib
{
    /// <summary>
    /// Класс собственного исключения транспорта.
    /// </summary>
    [Serializable]
    public class TransportException : Exception
    {
        /// <summary>
        /// Конструктор без параметров данного исключения.
        /// </summary>
        public TransportException() {}
    
        /// <summary>
        /// Конструктор с одним параметром данного исключения.
        /// </summary>
        /// <param name="message">Текст ошибки.</param>
        public TransportException(string message) : base(message) {}
    
        /// <summary>
        /// Конструктор исключения, вызванного другим.
        /// </summary>
        /// <param name="message">Текст ошибки.</param>
        /// <param name="inner">Исклбчение, вызвавшее данное.</param>
        public TransportException(string message, Exception inner) : base(message, inner) { }
    
        /// <summary>
        /// Конструктор для сериализации.
        /// </summary>
        /// <param name="info">Параметры сериализации.</param>
        /// <param name="context">Поток к файлу.</param>
        protected TransportException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}

