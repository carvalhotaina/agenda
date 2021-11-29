using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    class Tarefa : compromisso
    {
        private char propriedade;
        internal char Propriedade { get => propriedade; set => propriedade = value; }

        public Tarefa(
            string tipo = default, string titulo = default,string descricao = default,DateTime datahorainicio = default,DateTime datahorafim = default, char propriedade = default,Notificacao notificacao = default) : base(tipo,titulo, descricao, datahorainicio, datahorafim, notificacao)   
        {
          this.propriedade = propriedade;
        }
    }
}
