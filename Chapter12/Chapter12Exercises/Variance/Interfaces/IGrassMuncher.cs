namespace VarianceDemo
{
    /// <summary>
    /// Contravariant interface for the derived classes 
    /// of the Animal base class
    /// </summary>
    /// <typeparam name="T">The contravaraint type</typeparam>
    interface IGrassMuncher<in T> { }
}