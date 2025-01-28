namespace Numeros_Romanos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonInverter = new Button();
            label1TipoN1 = new Label();
            labelTipoN2 = new Label();
            textBoxValor1 = new TextBox();
            textBoxValor2 = new TextBox();
            SuspendLayout();
            // 
            // buttonInverter
            // 
            buttonInverter.Location = new Point(154, 110);
            buttonInverter.Name = "buttonInverter";
            buttonInverter.Size = new Size(75, 23);
            buttonInverter.TabIndex = 0;
            buttonInverter.Text = "Inverter";
            buttonInverter.UseVisualStyleBackColor = true;
            // 
            // label1TipoN1
            // 
            label1TipoN1.AutoSize = true;
            label1TipoN1.BorderStyle = BorderStyle.Fixed3D;
            label1TipoN1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1TipoN1.Location = new Point(76, 112);
            label1TipoN1.Name = "label1TipoN1";
            label1TipoN1.Size = new Size(59, 22);
            label1TipoN1.TabIndex = 1;
            label1TipoN1.Text = "Arábico";
            // 
            // labelTipoN2
            // 
            labelTipoN2.AutoSize = true;
            labelTipoN2.BorderStyle = BorderStyle.Fixed3D;
            labelTipoN2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipoN2.Location = new Point(252, 110);
            labelTipoN2.Name = "labelTipoN2";
            labelTipoN2.Size = new Size(63, 22);
            labelTipoN2.TabIndex = 2;
            labelTipoN2.Text = "Romano";
            // 
            // textBoxValor1
            // 
            textBoxValor1.Location = new Point(76, 153);
            textBoxValor1.Name = "textBoxValor1";
            textBoxValor1.Size = new Size(100, 23);
            textBoxValor1.TabIndex = 3;
            // 
            // textBoxValor2
            // 
            textBoxValor2.Location = new Point(215, 153);
            textBoxValor2.Name = "textBoxValor2";
            textBoxValor2.Size = new Size(100, 23);
            textBoxValor2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pilastra_romana;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 341);
            Controls.Add(textBoxValor2);
            Controls.Add(textBoxValor1);
            Controls.Add(labelTipoN2);
            Controls.Add(label1TipoN1);
            Controls.Add(buttonInverter);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor de romanos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInverter;
        private Label label1TipoN1;
        private Label labelTipoN2;
        private TextBox textBoxValor1;
        private TextBox textBoxValor2;
    }
}
