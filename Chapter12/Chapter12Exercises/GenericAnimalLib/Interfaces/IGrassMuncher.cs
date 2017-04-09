namespace GenericAnimalLib.Interfaces
{
    /// <summary>
    /// Contravariant interface for the derived classes 
    /// of the Animal base class
    /// </summary>
    /// <typeparam name="T">The contravaraint type</typeparam>
    public interface IGrassMuncher<in T> { }
}