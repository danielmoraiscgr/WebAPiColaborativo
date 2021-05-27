using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebAPiColaborativo.Interfaces;
using WebAPiColaborativo.Model;

namespace WebApiColaborativoDataDriven.Testes
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void ListagemDisciplinasTeste()
        {
            // Arrange
            Disciplina disciplina = new Disciplina();

            var listaDisciplinas = disciplina.GetDisciplinas();

            Mock<IDisciplina> mock = new Mock<IDisciplina>();
            mock.Setup(d => d.GetDisciplinas()).Returns(listaDisciplinas);

            // Act
            var listaDisciplinaMock = mock.Object.GetDisciplinas();


            // Assert

            Assert.AreEqual(listaDisciplinas.Count, listaDisciplinaMock.Count);
        }

        [TestMethod]
        public void BuscarGraduacaoProfessorByIdTeste()
        {
            // Arrange
            Professor professor = new Professor();
            Professor verificar = new Professor();

            professor.Id = 1;
            professor.Nome = "Pedro Neto";
            professor.Graduacao = "Mestre"; // No banco esta Mestre, caso mude aqui para outra graduacao o teste nao passa

            Mock<IProfessor> mock = new Mock<IProfessor>();
            mock.Setup(p => p.GetById(professor.Id)).Returns(professor);

            // Act
            var graducaoMock = mock.Object.GetById(professor.Id);

            var resultadoGraduacao = verificar.GetById(professor.Id);

            // Assert

            Assert.AreEqual(resultadoGraduacao.Graduacao, graducaoMock.Graduacao);

        }

      
        [TestMethod]
        [DataSource("System.Data.SqlClient",
            @"Data Source=127.0.0.1;Database=InstedDb;User=sa;Password=Teste@123",
            "professor", DataAccessMethod.Sequential)]
        public void teste() {
            Assert.AreEqual(1, 2);
        }
       

    }
}