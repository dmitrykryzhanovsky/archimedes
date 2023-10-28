namespace Archimedes.Tests
{
    /// <summary>
    /// Вспомогательный класс для тестирования методов, задействующих компаратор для пользовательских типов.
    /// </summary>
    /// <remarks>Семантический смысл данного класса – классы сравнения по модулю. Два объекта этого класса считаются меньшими / 
    /// равными /большими друг друга, если меньше / равны / больше их Value = _number mod _modulo.</remarks>
    internal class ModuloClass : IEquatable<ModuloClass>
    {
        private int _number;
        private int _modulo;

        internal int Value
        {
            get => _number % _modulo;
        }

        internal ModuloClass (int number, int modulo)
        {
            _number = number;
            _modulo = modulo;
        }

        public bool Equals (ModuloClass? other)
        {
            return (Value == other.Value);
        }
    }
}