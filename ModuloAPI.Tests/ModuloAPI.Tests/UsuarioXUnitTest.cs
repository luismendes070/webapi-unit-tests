// using Models.Usuario;
// using Controllers.UsuarioController;
using ModuloAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ModuloAPI.Tests
{
    public class UsuarioXUnit
    {
        [Fact]
        public async Task Usuario_X_Unit_Test()
        {
            // Arrange
            UsuarioController usuario = new UsuarioController();
            // Act
            usuario.ObterDataHora();

            // Assert
            Assert.Equal("Nome",usuario.Apresentar("Nome");
        }
    }
}