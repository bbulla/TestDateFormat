namespace Library.Tests;
using TestDateFormat;
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestsDataFormatter()
    {
        // Arrange
            const string dateFormatterValid = "06/09/2023";
            const string dateFormatterInvalid = "09/2023";
            const string dateFormatterNull = " ";

            // Act & Assert
            
            // Caso 1: Fecha válida
            string dateValid = DateFormatter.ChangeFormat(dateFormatterValid);
            Assert.AreEqual("2023-09-06", dateValid);
            // Caso 2: Fecha inválida
            string dateInvalid = DateFormatter.ChangeFormat(dateFormatterInvalid);
            Assert.AreEqual("Fecha ingresada inválida", dateInvalid);
            // Caso 3: Fecha nula
            string dateNull = DateFormatter.ChangeFormat(dateFormatterNull);
            Assert.AreEqual("Fecha ingresada inválida", dateInvalid);
    }
}