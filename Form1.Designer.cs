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
            buttonInvert = new Button();
            labelTypeN1 = new Label();
            labelTypeN2 = new Label();
            textBoxValue1 = new TextBox();
            textBoxValue2 = new TextBox();
            SuspendLayout();
            // 
            // buttonInvert
            // 
            buttonInvert.Location = new Point(154, 110);
            buttonInvert.Name = "buttonInvert";
            buttonInvert.Size = new Size(75, 23);
            buttonInvert.TabIndex = 0;
            buttonInvert.Text = "Inverter";
            buttonInvert.UseVisualStyleBackColor = true;
            buttonInvert.Click += buttonInvert_Click;
            // 
            // labelTypeN1
            // 
            labelTypeN1.AutoSize = true;
            labelTypeN1.BorderStyle = BorderStyle.Fixed3D;
            labelTypeN1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTypeN1.Location = new Point(76, 112);
            labelTypeN1.Name = "labelTypeN1";
            labelTypeN1.Size = new Size(59, 22);
            labelTypeN1.TabIndex = 1;
            labelTypeN1.Text = "Arábico";
            // 
            // labelTypeN2
            // 
            labelTypeN2.AutoSize = true;
            labelTypeN2.BorderStyle = BorderStyle.Fixed3D;
            labelTypeN2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTypeN2.Location = new Point(252, 110);
            labelTypeN2.Name = "labelTypeN2";
            labelTypeN2.Size = new Size(63, 22);
            labelTypeN2.TabIndex = 2;
            labelTypeN2.Text = "Romano";
            // 
            // textBoxValue1
            // 
            textBoxValue1.Location = new Point(76, 153);
            textBoxValue1.Name = "textBoxValue1";
            textBoxValue1.Size = new Size(100, 23);
            textBoxValue1.TabIndex = 3;
            textBoxValue1.TextChanged += textBoxValue1_TextChanged;
            // 
            // textBoxValue2
            // 
            textBoxValue2.Location = new Point(215, 153);
            textBoxValue2.Name = "textBoxValue2";
            textBoxValue2.Size = new Size(100, 23);
            textBoxValue2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pilastra_romana;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 341);
            Controls.Add(textBoxValue2);
            Controls.Add(textBoxValue1);
            Controls.Add(labelTypeN2);
            Controls.Add(labelTypeN1);
            Controls.Add(buttonInvert);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor de romanos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInvert;
        private Label labelTypeN1;
        private Label labelTypeN2;
        private TextBox textBoxValue1;
        private TextBox textBoxValue2;
    }
}
