using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pilas;
using porArrayTest;

namespace porArrayTest
{
    [TestClass]
    public class ColaTests
    {
        [TestMethod]
        public void InsertarYEliminar_Cola_ComportamientoEsperado()
        {
            // Arrange
            Cola cola = new Cola(3);

            // Act
            cola.Insertar(100);
            int eliminado = cola.Eliminar();

            // Assert
            Assert.AreEqual(100, eliminado, "El elemento eliminado debe ser el mismo que se insertó");
        }
    }
}

