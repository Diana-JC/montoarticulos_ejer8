namespace montoarticulos_ejer8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lbl_MontoNeto = new Label();
            btn_Calcular = new Button();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            txt_Descuento = new TextBox();
            txt_Itbis = new TextBox();
            txtMontoTotal = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(46, 260);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 0;
            label1.Text = "Descuento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(84, 336);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 1;
            label2.Text = "Itebis";
            // 
            // lbl_MontoNeto
            // 
            lbl_MontoNeto.AutoSize = true;
            lbl_MontoNeto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_MontoNeto.Location = new Point(29, 186);
            lbl_MontoNeto.Name = "lbl_MontoNeto";
            lbl_MontoNeto.Size = new Size(139, 30);
            lbl_MontoNeto.TabIndex = 3;
            lbl_MontoNeto.Text = "Monto Neto";
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_Calcular.Location = new Point(431, 184);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(112, 34);
            btn_Calcular.TabIndex = 4;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_Limpiar.Location = new Point(431, 234);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(112, 34);
            btn_Limpiar.TabIndex = 5;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_Salir.Location = new Point(431, 284);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(112, 34);
            btn_Salir.TabIndex = 6;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // txt_Descuento
            // 
            txt_Descuento.Location = new Point(199, 261);
            txt_Descuento.Name = "txt_Descuento";
            txt_Descuento.Size = new Size(150, 31);
            txt_Descuento.TabIndex = 7;
            // 
            // txt_Itbis
            // 
            txt_Itbis.Location = new Point(199, 335);
            txt_Itbis.Name = "txt_Itbis";
            txt_Itbis.Size = new Size(150, 31);
            txt_Itbis.TabIndex = 8;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(199, 187);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(150, 31);
            txtMontoTotal.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(141, 62);
            label3.Name = "label3";
            label3.Size = new Size(270, 45);
            label3.TabIndex = 10;
            label3.Text = "Monto_Articulos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(571, 426);
            Controls.Add(label3);
            Controls.Add(txtMontoTotal);
            Controls.Add(txt_Itbis);
            Controls.Add(txt_Descuento);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_MontoNeto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbl_MontoNeto;
        private Button btn_Calcular;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private TextBox txt_Descuento;
        private TextBox txt_Itbis;
        private TextBox txtMontoTotal;
        private Label label3;
    }
}
