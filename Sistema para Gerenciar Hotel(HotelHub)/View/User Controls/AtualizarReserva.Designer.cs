using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.UserViewsDTO;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View.Controls
{
    partial class AtualizarReserva
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            reservaBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorReservaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numHospedesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numQuartosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(182, 63);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 3;
            label1.Text = "Lista de Reservas";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, clienteDataGridViewTextBoxColumn, valorReservaDataGridViewTextBoxColumn, numHospedesDataGridViewTextBoxColumn, numQuartosDataGridViewTextBoxColumn });
            dataGridView1.DataSource = reservaBindingSource;
            dataGridView1.Location = new Point(43, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(442, 177);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // reservaBindingSource
            // 
            reservaBindingSource.DataSource = typeof(Reserva);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            clienteDataGridViewTextBoxColumn.HeaderText = "cliente";
            clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorReservaDataGridViewTextBoxColumn
            // 
            valorReservaDataGridViewTextBoxColumn.DataPropertyName = "valorReserva";
            valorReservaDataGridViewTextBoxColumn.HeaderText = "valor";
            valorReservaDataGridViewTextBoxColumn.Name = "valorReservaDataGridViewTextBoxColumn";
            valorReservaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numHospedesDataGridViewTextBoxColumn
            // 
            numHospedesDataGridViewTextBoxColumn.DataPropertyName = "numHospedes";
            numHospedesDataGridViewTextBoxColumn.HeaderText = "hóspedes";
            numHospedesDataGridViewTextBoxColumn.Name = "numHospedesDataGridViewTextBoxColumn";
            numHospedesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numQuartosDataGridViewTextBoxColumn
            // 
            numQuartosDataGridViewTextBoxColumn.DataPropertyName = "numQuartos";
            numQuartosDataGridViewTextBoxColumn.HeaderText = "quartos";
            numQuartosDataGridViewTextBoxColumn.Name = "numQuartosDataGridViewTextBoxColumn";
            numQuartosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AtualizarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "AtualizarReserva";
            Size = new Size(529, 350);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource reservaBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorReservaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numHospedesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numQuartosDataGridViewTextBoxColumn;
    }
}
