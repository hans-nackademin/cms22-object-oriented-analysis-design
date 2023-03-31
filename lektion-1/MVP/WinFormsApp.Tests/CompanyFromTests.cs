using System.Reflection.Metadata;
using WinFormsApp.Library.Presenters;
using WinFormsApp.Tests.Models;

namespace WinFormsApp.Tests
{
    [TestClass]
    public class CompanyFromTests
    {
        [TestMethod]
        public void Should_Display_CompanyName_Required_Error_When_Null()
        {
            // arrange
            CompanyForm form = new CompanyForm();
            var presenter = new CompanyFormPresenter(form);

            // act
            form.Save();

            // assert
            Assert.AreEqual(null, form.CompanyName, "Company Name should be initialized as null!");
            Assert.IsTrue(form.Display_CompanyName_Error, "Null on Company Name should trigger validation error");
            Assert.AreEqual("Company Name is required.", form.CompanyName_Error);

        }

        [TestMethod]
        public void Should_Display_Email_Required_Error_When_Null()
        {
            // arrange
            CompanyForm form = new CompanyForm();
            var presenter = new CompanyFormPresenter(form);

            // act
            form.Save();

            // assert
            Assert.AreEqual(null, form.Email, "Email should be initialized as null!");
            Assert.IsTrue(form.Display_Email_Error, "Null on Email should trigger validation error");
            Assert.AreEqual("Email is required.", form.Email_Error);
        }
    }
}