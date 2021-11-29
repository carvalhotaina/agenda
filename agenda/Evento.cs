using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    class Evento : compromisso
    {
        private string local;
        private List<string> convidados;

        internal string Local { get => local; set => local = value; }
        internal List<string> Convidados { get => convidados; set => convidados = value; }
        public Evento(string tipo = default,string titulo = default, string descricao = default,DateTime datahorainicio = default, DateTime datahorafim = default,string local = default,Notificacao notificacao = default,string convidados = default): base(tipo,titulo, descricao, datahorainicio, datahorafim, notificacao)
        {
            this.local = local;
            this.convidados = new List<string>();
            if (convidados != null)
            {
                this.convidados.Add(convidados);
            }
        }  
    }
}

