using System;

using System.Collections.Generic;

namespace agenda
{
    public abstract class compromisso
    {   
        protected string tipo;
        protected string titulo;
        protected string descricao;
        protected DateTime datahorainicio;
        protected DateTime  datahorafim;
        protected List<Notificacao> notificacao;
 
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Datahorainicio { get => datahorainicio; set => datahorainicio = value; }
        public DateTime Datahorafim { get => datahorafim; set => datahorafim = value; }
        public List<Notificacao> Notificacao { get => notificacao; set => notificacao = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public compromisso(string tipo,string titulo, string descricao, DateTime datahorainicio, DateTime datahorafim, Notificacao Notificacao)
        {
            this.tipo = tipo;
            this.titulo = titulo;
            this.descricao = descricao;
            this.datahorainicio = datahorainicio;
            this.datahorafim = datahorafim;
           
                notificacao = new List<Notificacao>();
            if (Notificacao != null)
            {
            
                notificacao.Add(Notificacao);
            }
        }
        public override string ToString()
        {
            return $" {titulo},{descricao},{datahorainicio} e {datahorafim}";
        }
    }
}
