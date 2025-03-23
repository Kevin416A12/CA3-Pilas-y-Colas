using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace porArrayTest
{
    [TestClass]
    public class PilaTests
    {
        [TestMethod]
        public void PushYPop_Pila_ComportamientoEsperado()
        {
            // Arrange
            Pila pila = new Pila(3);

            // Act
            pila.Push(200);
            int eliminado = pila.Pop();

            // Assert
            Assert.AreEqual(200, eliminado, "El elemento eliminado debe ser el mismo que se insertó");
        }
    }
}