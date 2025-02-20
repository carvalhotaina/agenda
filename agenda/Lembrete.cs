﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    class Lembrete : compromisso
    {
        private byte tempoLemebrete;
        private char tipoLembrete;
        private ValueTuple<bool, bool, bool, bool, bool, bool,bool> diaLembrete = (false,false,false,false,false,false,false);
        private int tempopara;
        private DateTime datepara;
        internal byte TempoLemebrete { get => tempoLemebrete; set => tempoLemebrete = value; }
        internal char TipoLembrete { get => tipoLembrete; set => tipoLembrete = value; }
        internal ValueTuple<bool, bool, bool, bool, bool, bool, bool> DiaLembrete { get => diaLembrete; set => diaLembrete = value; }
        internal int TempoPara { get => tempopara; set => tempopara = value; }
        internal DateTime DatePara { get => datepara; set => datepara = value; }
        

        public Lembrete(string tipo = default,string titulo = default,string descricao = default,DateTime datahorainicio = default,DateTime datahorafim = default,byte tempoLemebrete = default,char tipoLembrete = default, ValueTuple<bool, bool, bool, bool, bool, bool, bool> diaLembrete = default,DateTime datepara = default, int tempopara = default, Notificacao notificacao = default) : base(tipo,titulo, descricao, datahorainicio, datahorafim, notificacao)
        {
            this.tempopara = tempopara;
            this.datepara = datepara;
            this.diaLembrete = diaLembrete;
            this.tipoLembrete = tipoLembrete;
            this.tempoLemebrete = tempoLemebrete;
        }
    }
}

