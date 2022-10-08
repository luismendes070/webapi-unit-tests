using ModuloAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ModuloAPI.Properties
{
    public class UsuarioTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            UsuarioController usuario = new UsuarioController();
            // Act
            usuario.ObterDataHora();

            // Assert
            Assert.Equal("Nome", usuario.Apresentar("Nome");
        }
    }
}