using System;
using Moq;
using WebAPiColaborativo.Interfaces;
using WebAPiColaborativo.Model;
using Xunit;

namespace WebAPIColaborativo.Testes
{
    public class UnitTest1
    {
        [Fact]
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

            Assert.Equal(listaDisciplinas.Count, listaDisciplinaMock.Count);
        }
        }
    }
