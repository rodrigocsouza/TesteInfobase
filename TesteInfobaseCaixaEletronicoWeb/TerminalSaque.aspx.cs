using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLLInfobase.Exceptions;

namespace TesteInfobaseCaixaEletronicoWeb
{
    public partial class TerminalSaque : ViewInfobase.Commom.BasePage
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Somente para apresentar as notas disponíveis no caixa eletrônico
                GridView1.DataSource = Caixa.NotasDisponiveis;
                GridView1.DataBind();
            }
        }

        protected void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                //Realiza o saque efetivamente
                int valorSaque = 0;
                Int32.TryParse(txbValorSaque.Text, out valorSaque);
                Caixa.ValorSaque = valorSaque;
                Caixa.RealizarSaque();
                gvNotasEntrega.DataSource = Caixa.NotasSaque;
                gvNotasEntrega.DataBind();
                lblResultado.Text = Caixa.ResumoSaque();
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                gvNotasEntrega.DataSource = null;
                gvNotasEntrega.DataBind();
            }
        }
    }
}