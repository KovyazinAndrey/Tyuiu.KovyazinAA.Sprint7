namespace Project.V1
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            panelAbout_KAA = new Panel();
            buttonClose_KAA = new Button();
            textBoxAbout_KAA = new TextBox();
            panelAbout_KAA.SuspendLayout();
            SuspendLayout();
            // 
            // panelAbout_KAA
            // 
            panelAbout_KAA.Controls.Add(buttonClose_KAA);
            panelAbout_KAA.Controls.Add(textBoxAbout_KAA);
            panelAbout_KAA.Dock = DockStyle.Fill;
            panelAbout_KAA.Location = new Point(0, 0);
            panelAbout_KAA.Name = "panelAbout_KAA";
            panelAbout_KAA.Size = new Size(422, 303);
            panelAbout_KAA.TabIndex = 0;
            // 
            // buttonClose_KAA
            // 
            buttonClose_KAA.Cursor = Cursors.Hand;
            buttonClose_KAA.Location = new Point(300, 224);
            buttonClose_KAA.Name = "buttonClose_KAA";
            buttonClose_KAA.Size = new Size(110, 67);
            buttonClose_KAA.TabIndex = 1;
            buttonClose_KAA.Text = "OK";
            buttonClose_KAA.UseVisualStyleBackColor = true;
            buttonClose_KAA.Click += buttonClose_KAA_Click;
            // 
            // textBoxAbout_KAA
            // 
            textBoxAbout_KAA.Location = new Point(12, 12);
            textBoxAbout_KAA.Multiline = true;
            textBoxAbout_KAA.Name = "textBoxAbout_KAA";
            textBoxAbout_KAA.ReadOnly = true;
            textBoxAbout_KAA.Size = new Size(398, 206);
            textBoxAbout_KAA.TabIndex = 0;
            textBoxAbout_KAA.TabStop = false;
            textBoxAbout_KAA.Text = resources.GetString("textBoxAbout_KAA.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 303);
            Controls.Add(panelAbout_KAA);
            MaximumSize = new Size(440, 350);
            MinimumSize = new Size(440, 350);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            panelAbout_KAA.ResumeLayout(false);
            panelAbout_KAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAbout_KAA;
        private TextBox textBoxAbout_KAA;
        private Button buttonClose_KAA;
    }
}