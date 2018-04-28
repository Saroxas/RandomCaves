namespace RandomCaves
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.richTextBoxMap = new System.Windows.Forms.RichTextBox();
            this.buttonGenerateNewMap = new System.Windows.Forms.Button();
            this.labelXLength = new System.Windows.Forms.Label();
            this.numericUpDownXLength = new System.Windows.Forms.NumericUpDown();
            this.labelYLength = new System.Windows.Forms.Label();
            this.numericUpDownYLength = new System.Windows.Forms.NumericUpDown();
            this.labelWallChance = new System.Windows.Forms.Label();
            this.numericUpDownWallChance = new System.Windows.Forms.NumericUpDown();
            this.buttonIterateMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWallChance)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxMap
            // 
            resources.ApplyResources(this.richTextBoxMap, "richTextBoxMap");
            this.richTextBoxMap.Name = "richTextBoxMap";
            this.richTextBoxMap.ReadOnly = true;
            // 
            // buttonGenerateNewMap
            // 
            resources.ApplyResources(this.buttonGenerateNewMap, "buttonGenerateNewMap");
            this.buttonGenerateNewMap.Name = "buttonGenerateNewMap";
            this.buttonGenerateNewMap.UseVisualStyleBackColor = true;
            this.buttonGenerateNewMap.Click += new System.EventHandler(this.buttonGenerateNewMap_Click);
            // 
            // labelXLength
            // 
            resources.ApplyResources(this.labelXLength, "labelXLength");
            this.labelXLength.Name = "labelXLength";
            // 
            // numericUpDownXLength
            // 
            resources.ApplyResources(this.numericUpDownXLength, "numericUpDownXLength");
            this.numericUpDownXLength.Name = "numericUpDownXLength";
            this.numericUpDownXLength.ValueChanged += new System.EventHandler(this.numericUpDownXLength_ValueChanged);
            // 
            // labelYLength
            // 
            resources.ApplyResources(this.labelYLength, "labelYLength");
            this.labelYLength.Name = "labelYLength";
            // 
            // numericUpDownYLength
            // 
            resources.ApplyResources(this.numericUpDownYLength, "numericUpDownYLength");
            this.numericUpDownYLength.Name = "numericUpDownYLength";
            this.numericUpDownYLength.ValueChanged += new System.EventHandler(this.numericUpDownYLength_ValueChanged);
            // 
            // labelWallChance
            // 
            resources.ApplyResources(this.labelWallChance, "labelWallChance");
            this.labelWallChance.Name = "labelWallChance";
            // 
            // numericUpDownWallChance
            // 
            resources.ApplyResources(this.numericUpDownWallChance, "numericUpDownWallChance");
            this.numericUpDownWallChance.Name = "numericUpDownWallChance";
            this.numericUpDownWallChance.ValueChanged += new System.EventHandler(this.numericUpDownWallChance_ValueChanged);
            // 
            // buttonIterateMap
            // 
            resources.ApplyResources(this.buttonIterateMap, "buttonIterateMap");
            this.buttonIterateMap.Name = "buttonIterateMap";
            this.buttonIterateMap.UseVisualStyleBackColor = true;
            this.buttonIterateMap.Click += new System.EventHandler(this.buttonIterateMap_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonIterateMap);
            this.Controls.Add(this.numericUpDownWallChance);
            this.Controls.Add(this.labelWallChance);
            this.Controls.Add(this.numericUpDownYLength);
            this.Controls.Add(this.labelYLength);
            this.Controls.Add(this.numericUpDownXLength);
            this.Controls.Add(this.labelXLength);
            this.Controls.Add(this.buttonGenerateNewMap);
            this.Controls.Add(this.richTextBoxMap);
            this.Name = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWallChance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxMap;
        private System.Windows.Forms.Button buttonGenerateNewMap;
        private System.Windows.Forms.Label labelXLength;
        private System.Windows.Forms.NumericUpDown numericUpDownXLength;
        private System.Windows.Forms.Label labelYLength;
        private System.Windows.Forms.NumericUpDown numericUpDownYLength;
        private System.Windows.Forms.Label labelWallChance;
        private System.Windows.Forms.NumericUpDown numericUpDownWallChance;
        private System.Windows.Forms.Button buttonIterateMap;
    }
}

