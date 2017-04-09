namespace GenericAnimalLib.Interfaces
{
    /// <summary>
    /// Covaraint interface for the Animal class and 
    /// its derived classes 
    /// </summary>
    /// <typeparam name="T">The covariant type</typeparam>
    public interface IMethaneProducer<out T> { }
}