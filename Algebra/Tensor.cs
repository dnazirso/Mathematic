namespace Algebra
{
    public struct Tensor
    {
        /// <summary>
        /// Reprensents the <see cref="Tensor"/> itslef
        /// </summary>
        public readonly float[,,] tens { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tens"></param>
        public Tensor(float[,,] tens)
        {
            this.tens = tens;
        }

        /// <summary>
        /// Allow to write : <see cref="Tensor"/> A = new float[,,]{};
        /// </summary>
        /// <param name="tens">a float[,,]</param>
        public static implicit operator Tensor(float[,,] tens) => new Tensor(tens);

        /// <summary>
        /// Allow to write : float[,,] A = (<see cref="Tensor"/>)B
        /// </summary>
        /// <param name="A"></param>
        public static explicit operator float[,,](Tensor A) => A.tens;
    }
}
