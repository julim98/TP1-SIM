namespace TP1_SIM
{
    partial class FormMenuTP1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRaiz = new System.Windows.Forms.Label();
            this.txtRaiz = new System.Windows.Forms.TextBox();
            this.cbMultiplicativo = new System.Windows.Forms.CheckBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cbMixto = new System.Windows.Forms.CheckBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.lblM = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.lblK = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.ite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaiz
            // 
            this.lblRaiz.AutoSize = true;
            this.lblRaiz.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaiz.Location = new System.Drawing.Point(50, 41);
            this.lblRaiz.Name = "lblRaiz";
            this.lblRaiz.Size = new System.Drawing.Size(72, 19);
            this.lblRaiz.TabIndex = 0;
            this.lblRaiz.Text = "Raiz (X0):";
            // 
            // txtRaiz
            // 
            this.txtRaiz.Location = new System.Drawing.Point(128, 40);
            this.txtRaiz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRaiz.Name = "txtRaiz";
            this.txtRaiz.Size = new System.Drawing.Size(65, 26);
            this.txtRaiz.TabIndex = 1;
            // 
            // cbMultiplicativo
            // 
            this.cbMultiplicativo.AutoSize = true;
            this.cbMultiplicativo.Location = new System.Drawing.Point(132, 126);
            this.cbMultiplicativo.Name = "cbMultiplicativo";
            this.cbMultiplicativo.Size = new System.Drawing.Size(115, 20);
            this.cbMultiplicativo.TabIndex = 7;
            this.cbMultiplicativo.Text = "Multiplicativo";
            this.cbMultiplicativo.UseVisualStyleBackColor = true;
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodo.Location = new System.Drawing.Point(50, 125);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(66, 19);
            this.lblMetodo.TabIndex = 4;
            this.lblMetodo.Text = "Metodo:";
            // 
            // cbMixto
            // 
            this.cbMixto.AutoSize = true;
            this.cbMixto.Location = new System.Drawing.Point(270, 126);
            this.cbMixto.Name = "cbMixto";
            this.cbMixto.Size = new System.Drawing.Size(63, 20);
            this.cbMixto.TabIndex = 8;
            this.cbMixto.Text = "Mixto";
            this.cbMixto.UseVisualStyleBackColor = true;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ite,
            this.rnd});
            this.dgvTabla.Location = new System.Drawing.Point(54, 174);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(364, 247);
            this.dgvTabla.TabIndex = 6;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(236, 479);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(54, 427);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(343, 479);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(50, 86);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(21, 19);
            this.lblA.TabIndex = 10;
            this.lblA.Text = "a:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(77, 85);
            this.txtA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(39, 26);
            this.txtA.TabIndex = 2;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(128, 85);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(20, 19);
            this.lblC.TabIndex = 12;
            this.lblC.Text = "c:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(154, 84);
            this.txtC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(39, 26);
            this.txtC.TabIndex = 3;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(236, 84);
            this.txtM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(39, 26);
            this.txtM.TabIndex = 4;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(204, 86);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(26, 19);
            this.lblM.TabIndex = 15;
            this.lblM.Text = "m:";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(320, 84);
            this.txtK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(39, 26);
            this.txtK.TabIndex = 5;
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblK.Location = new System.Drawing.Point(293, 86);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(21, 19);
            this.lblK.TabIndex = 17;
            this.lblK.Text = "k:";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(376, 86);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(22, 19);
            this.lblG.TabIndex = 18;
            this.lblG.Text = "g:";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(403, 84);
            this.txtG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(39, 26);
            this.txtG.TabIndex = 6;
            // 
            // ite
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ite.DefaultCellStyle = dataGridViewCellStyle3;
            this.ite.HeaderText = "i";
            this.ite.Name = "ite";
            this.ite.Width = 160;
            // 
            // rnd
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N4";
            dataGridViewCellStyle4.NullValue = null;
            this.rnd.DefaultCellStyle = dataGridViewCellStyle4;
            this.rnd.HeaderText = "RND";
            this.rnd.MaxInputLength = 6;
            this.rnd.Name = "rnd";
            this.rnd.Width = 160;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(424, 398);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 19;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // FormMenuTP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 527);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.cbMixto);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.cbMultiplicativo);
            this.Controls.Add(this.txtRaiz);
            this.Controls.Add(this.lblRaiz);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMenuTP1";
            this.Text = "Serie De Numeros Aleatorios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaiz;
        private System.Windows.Forms.TextBox txtRaiz;
        private System.Windows.Forms.CheckBox cbMultiplicativo;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.CheckBox cbMixto;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ite;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd;
        private System.Windows.Forms.Button btnProximo;
    }
}

