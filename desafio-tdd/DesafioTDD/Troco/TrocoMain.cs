using System;
using DesafioTDD.Troco.Models;
using DesafioTDD.Troco.Services;

namespace DesafioTDD.Troco
{
    public class TrocoMain
    {
        public void Main()
        {
            var troco = Services.Troco.ValidaTroco();
            var cedulas = Services.Troco.CedulasTroco(troco);
            var moedas = Services.Troco.MoedasTroco(cedulas.moedas);
            Services.Troco.ResultadoCedula(cedulas, troco);
            Services.Troco.ResultadoMoeda(moedas, troco);
        }
    }
}