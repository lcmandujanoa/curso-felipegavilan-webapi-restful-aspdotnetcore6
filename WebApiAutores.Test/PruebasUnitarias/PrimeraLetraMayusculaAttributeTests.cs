using System.ComponentModel.DataAnnotations;
using WebApiAutores.Validaciones;

namespace WebApiAutores.Test.PruebasUnitarias
{
    [TestClass]
    public class PrimeraLetraMayusculaAttributeTests
    {
        [TestMethod]
        public void PrimeraLetraMinuscula_DevuelveError()
        {
            // Preparaci�n
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            var valor = "luis";
            var valContext = new ValidationContext(new { Nombre = valor });

            // Ejecuci�n
            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            // Verificaci�n
            Assert.AreEqual("La primera letra debe ser may�scula", resultado.ErrorMessage);
        }

        [TestMethod]
        public void ValorNulo_NoDevuelveError()
        {
            // Preparaci�n
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            string valor = null;
            var valContext = new ValidationContext(new { Nombre = valor });

            // Ejecuci�n
            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            // Verificaci�n
            Assert.IsNull(resultado);
        }

        [TestMethod]
        public void ValorConPrimeraLetraMayuscula_NoDevuelveError()
        {
            // Preparaci�n
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            string valor = "Felipe";
            var valContext = new ValidationContext(new { Nombre = valor });

            // Ejecuci�n
            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            // Verificaci�n
            Assert.IsNull(resultado);
        }
    }
}