using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace agenda
{
    public enum EnumTipoLembrete
    {
        Dia = 'D',
        Semana = 'S',
        Mês = 'M',
        Ano = 'A',
    }
    public enum EnumPrioridade
    {
        Urgente = 'U',
        Alta = 'A',
        Normal = 'N',
        Baixa = 'B',
        Minima = 'M',
    }
    public enum EnumUnidade
    {
        Minutos = 'm',
        Horas = 'H',
        Dias = 'D',
        Semanas = 'S',  
        Meses = 'M',
        Anos = 'A'
    }
    public enum EnumTipo
    {
        [Description("E-mail")]
        Email = 'E',
        [Description("Notificação")]
        Notificação = 'N',
        [Description("Tremer")]
        Tremer = 'T'
    }

    public partial class FormAgenda : Form
    {
        List<compromisso> agenda;
        public FormAgenda(List<compromisso> agenda)
        {

            this.agenda = agenda;
            InitializeComponent();
    
            var e1 = new Evento("Evento","E1", "evento 1", new DateTime(2021, 11, 20, 22, 00, 0), new DateTime(2021, 11, 21, 23, 00, 0),  "casa da mae joANA ", new Notificacao(4, 'D', 'T'), "DOLLYNHOSEUAMIGUINHO123");
            agenda.Add(e1);
            
            SortAndShowComp();
         
            monthCalendarDataInicio.MaxSelectionCount = 1;
            monthCalendarDataFim.MaxSelectionCount = 1;
            StartPosition = FormStartPosition.Manual;
            Location = new(0, 0);

        }
        public void SortAndShowNoti()
        {

            dynamic aux = (dynamic)DataGridComp.CurrentRow.DataBoundItem;
            DataGridNoti.DataSource = null;
            DataGridNoti.Rows.Clear();
            DataGridNoti.DataSource = aux.Notificacao;

        }
        public void SortAndShowComp()
        {
            if (agenda.Count > 0)
            {
               
                agenda.Sort((x, y) => x.Datahorainicio.CompareTo(y.Datahorainicio));
                DataGridComp.DataSource = null;
                DataGridComp.Rows.Clear();
                DataGridComp.DataSource = agenda;
            }


        }
        private void ButtonNovoEvento_Click(object sender, EventArgs e)
        {
            Evento aux = new();
            FormCompromisso FormComp =  new FormCompromisso(aux,agenda, DataGridComp, monthCalendarDataInicio, monthCalendarDataFim);
            FormComp.TarefaVisible(false);
            FormComp.LembreteVisible(false);
            FormComp.NotiVisible(false);
            FormComp.ShowDialog();
            
           
        }
        private void ButtonNovoTarefa_Click(object sender, EventArgs e)
        {
            Tarefa aux = new();
            FormCompromisso FormComp = new FormCompromisso(aux,agenda, DataGridComp, monthCalendarDataInicio, monthCalendarDataFim);
            FormComp.EventoVisible(false);
            FormComp.LembreteVisible(false);
            FormComp.NotiVisible(false);
            FormComp.ShowDialog();
        }
         private void buttonNovoLembrete_Click(object sender, EventArgs e)
        {
            Lembrete aux = new();
            FormCompromisso FormComp = new FormCompromisso(aux, agenda, DataGridComp, monthCalendarDataInicio, monthCalendarDataFim);
            FormComp.EventoVisible(false);
            FormComp.TarefaVisible(false);
            FormComp.NotiVisible(false);
            FormComp.ShowDialog();
        }
        private void DataGridComp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridComp.SelectedRows.Count != 0)
            {

                dynamic aux = DataGridComp.CurrentRow.DataBoundItem;
                monthCalendarDataInicio.SelectionStart = aux.Datahorainicio;
                monthCalendarDataFim.SelectionEnd = aux.Datahorafim;
                SortAndShowNoti();


            }
        }

        private void DataGridComp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

                if (DataGridComp.SelectedRows.Count != 0)
                {
                 SortAndShowNoti();
                 dynamic aux = DataGridComp.CurrentRow.DataBoundItem;
                 FormCompromisso FormComp = new FormCompromisso(aux, agenda, DataGridComp, DataGridNoti);
                  switch (aux)
                  {

                        case Evento:
                        FormComp.TarefaVisible(false);
                        FormComp.LembreteVisible(false);
                        break;

                        case Tarefa:
                        FormComp.EventoVisible(false);
                        FormComp.LembreteVisible(false);
                        break;

                        case Lembrete:
                        FormComp.EventoVisible(false);
                        FormComp.TarefaVisible(false);
                        break;
                  }
                   FormComp.ShowDialog();
                    DataGridNoti.DataSource = null;
                    DataGridNoti.Rows.Clear();                
                }
        }

        
        private void DataGridComp_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            DataGridComp.ClearSelection();
        }

        private void DataGridNoti_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridNoti.ClearSelection();
        }

        private void DataGridComp_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = DataGridComp.HitTest(e.X, e.Y);
            if (hit.Type != DataGridViewHitTestType.Cell)
                DataGridComp.ClearSelection();
                DataGridNoti.DataSource = null;
        }
        private void DataGridNoti_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex != DataGridNoti.NewRowIndex)
            {
                if (e.Value != null)
                {
                    if (e.ColumnIndex == 1)
                    {
                        e.Value = (EnumUnidade)(char)e.Value;
                    }
                    if (e.ColumnIndex == 2)
                    {
                        e.Value = (EnumTipo)(char)e.Value;
                    }
                }
            }
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
     

}
