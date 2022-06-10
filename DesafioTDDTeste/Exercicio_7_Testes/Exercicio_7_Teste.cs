using System;
using Xunit;
using Exercicio_7.Models;
using System.Collections.Generic;
using Xunit.Abstractions;

namespace Exercicio_7Teste
{
    public class Exercicio7Teste
    {
        ITestOutputHelper _output;
        public Exercicio7Teste(ITestOutputHelper output)
        {
            _output = output;
        }
        public static IEnumerable<object[]> GerenteList = new[]{
          new [] {new Gerente ("Raphael Azevedo", 24, 15000)},
          new [] {new Gerente ("Otaviano Lopes", 58, 9300)},
          new [] {new Gerente ("Nathalie", 33, 9450)},
        };
        public static IEnumerable<object[]> SupervisorList = new[]{
          new [] {new Supervisor ("Larissa", 28, 5020)},
          new [] {new Supervisor ("Gustavo", 35, 4300)},
          new [] {new Supervisor ("Gabriela", 30, 4000)},
        };
        public static IEnumerable<object[]> VendedorList = new[]{
          new [] {new Vendedor ("Valéria", 55, 2300)},
          new [] {new Vendedor ("Gabriel", 20, 1600)},
          new [] {new Vendedor ("Talisson", 36, 1800)},
        };

        [Theory(DisplayName = " O Campo nome do Gerente esta preenchido")]
        [Trait("Categoria", "Gerente")]
        [MemberData(nameof(GerenteList))]
        public void OsCamposDoGerenteDevemEstarPreenchido(Gerente gerente)
        {
            Assert.NotEmpty(gerente.Nome);
            Assert.IsType<Gerente>(gerente);
        }
        
        [Theory(DisplayName = " O Campo nome do Supervisor esta preenchido")]
        [Trait("Categoria", "Supervisor")]
        [MemberData(nameof(SupervisorList))]
        public void OsCamposDoSupervisorDevemEstarPreenchido(Supervisor supervisor)
        {
            Assert.NotEmpty(supervisor.Nome);
            Assert.IsType<Supervisor>(supervisor);
        }

        [Theory(DisplayName = " O Campo nome do Vendedor esta preenchido")]
        [Trait("Categoria", "Vendedor")]
        [MemberData(nameof(VendedorList))]
        public void OsCamposDoVendedorDevemEstarPreenchido(Vendedor vendedor)
        {
            Assert.NotEmpty(vendedor.Nome);
            Assert.IsType<Vendedor>(vendedor);
        }

        [Theory(DisplayName = " Deve calcular corretamente a bonificação do gerente")]
        [Trait("Categoria", "Gerente")]
        [MemberData(nameof(GerenteList))]
        public void DeveCalcularBonificacaoParaGerente(Gerente gerente)
        {
            // Arange
            var bonusParaGerente = 10000;
            var bonus = bonusParaGerente + gerente.Salario;
            // Act
            var resultado = gerente.Bonificacao();
            // Assert
            _output.WriteLine($"Expectativa: {bonus}, Resultado: {resultado}");
            Assert.Equal(bonus, resultado);
        }

        [Theory(DisplayName = " Deve calcular corretamente a bonificação do supervisor")]
        [Trait("Categoria", "Supervisor")]
        [MemberData(nameof(SupervisorList))]
        public void DeveCalcularBonificacaoParaSupervisor(Supervisor supervisor)
        {
            // Arange
            var bonusParaSupervisor = 5000;
            var bonus = bonusParaSupervisor + supervisor.Salario;
            // Act
            var resultado = supervisor.Bonificacao();
            // Assert
            _output.WriteLine($"Expectativa: {bonus}, Resultado: {resultado}");
            Assert.Equal(bonus, resultado);
        }
        
        [Theory(DisplayName = " Deve calcular corretamente a bonificação do vendedor")]
        [Trait("Categoria", "Vendedor")]
        [MemberData(nameof(VendedorList))]
        public void DeveCalcularBonificacaoParaVendedor(Vendedor vendedor)
        {
            // Arange
            var bonusParaVendedor = 3000;
            var bonus = bonusParaVendedor + vendedor.Salario;
            // Act
            var resultado = vendedor.Bonificacao();
            // Assert
            _output.WriteLine($"Expectativa: {bonus}, Resultado: {resultado}");
            Assert.Equal(bonus, resultado);
        }
    }
}
