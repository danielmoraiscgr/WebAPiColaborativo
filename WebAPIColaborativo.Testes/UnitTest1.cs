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

        [Fact]
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

            Assert.Equal(resultadoGraduacao.Graduacao, graducaoMock.Graduacao);

        }

        }
    }
